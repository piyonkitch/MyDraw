/*
Copyright(c) 2022, piyonkitch<kazuo.horikawa.ko@gmail.com>
All rights reserved.
Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
* Redistributions of source code must retain the above copyright notice, this
  list of conditions and the following disclaimer.
* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.
* Neither the name of roguelike nor the names of its
  contributors may be used to endorse or promote products derived from
  this software without specific prior written permission.
THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED.IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
OR TORT(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Console.WriteLine()先を入れ替える
using System.IO;
using System.Drawing.Drawing2D;

namespace MyDraw
{
    public partial class MyDraw : Form
    {
        Timer timer;
        const int Dots = 1; // このプログラムは11pixelの□(四角)ではなく、点
        Logic logic = new Logic();

        // エントリーポイント
        public MyDraw()
        {
            InitializeComponent();
            // Console.WriteLine()先にtextBoxConsoleを追加
            Console.SetOut(new TextBoxWriter(textBoxConsole));

            // Tick count timer at 10ms
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new EventHandler(myTick);
            timer.Start();


            // GUIへのイベントハンドラをここで追加
            // pic(キャンバス)
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
        }

        /// <summary>
        /// Display all the entities on MyDraw.pic
        /// </summary>
//        private void show()
        private void show(PictureBox pic, List<Entity>entityList)
        {
            // Bitmap canvas where this application draws lines.
            Bitmap canvas = new Bitmap(pic.Width, pic.Height);
            Graphics g = Graphics.FromImage(canvas);

            // Use an arrow (→) for a ship
            Pen penShip = new Pen(Color.White, 5);
            penShip.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            // Rock(Wall) is Blue□, crash is red ○, bullet is white.
            Pen penRock = new Pen(Color.Blue, 1);
            Pen penRockRec = new Pen(Color.Red, 1);  // Recognized rock
            Pen penCrash = new Pen(Color.Red, 1);
            Pen penBullet = new Pen(Color.White, 1);
            Font fnt = new Font("Arial", 10);
            // 線分は白の矢印線
            Pen penLine = new Pen(Color.White, 1);
            penLine.CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(4, 4);
            // 補助線は明るい緑色の線
            Pen penLineSupport = new Pen(Color.LightGreen, 1);

#if false
            // ぐりぐり回転はうまくいっていない
            g.ResetTransform();
            g.TranslateTransform((float)myship.xpos, (float)myship.ypos);
            g.RotateTransform( (float) ((-myship.head_theta / Math.PI) * 180) - 90 /* look up */);
            g.TranslateTransform(-(float)myship.xpos, -(float)myship.ypos);
#endif

            // 過去の残骸
            g.DrawRectangle(
                penRock,
                (int)100, (int)100, 4 /* w */, 4 /* h */);
            // 過去の残骸
            g.DrawEllipse(penBullet, 200, 200, 3 /* w */, 3 /* h */);
            // 過去の残骸
            g.DrawLine(penShip,
                (float)50,
                (float)200,
                (float)(50 + 10 * Math.Cos(1.0)),
                (float)(200 + 10 * Math.Sin(1.0))
                );
            g.DrawString("MyShip", fnt, Brushes.White,
                (float)50.0 + 8, (float)200 + 8);

            foreach (Entity ent in entityList)
            {
                // 各クラスにDrawさせてもよいが、描画はここで一元管理
                if (ent.GetType() == typeof(EntityLine))
                {
                    if (((EntityLine)ent).IsSupport)
                    {
                        g.DrawLine(penLineSupport, ((EntityLine)ent).StartPoint, ((EntityLine)ent).EndPoint);
                    }
                    else
                    {
                        g.DrawLine(penLine, ((EntityLine)ent).StartPoint, ((EntityLine)ent).EndPoint);
                    }
                    g.DrawString(ent.Name, fnt, Brushes.White,
                        (float)ent.CenterPoint.X + 4, (float)ent.CenterPoint.Y + 4);
                }
                else if (ent.GetType() == typeof(Entity))
                {
                    g.DrawEllipse(penBullet, ent.CenterPoint.X, ent.CenterPoint.Y, 3 /* w */, 3 /* h */);
                    g.DrawString(ent.Name, fnt, Brushes.White,
                        (float)ent.CenterPoint.X + 4, (float)ent.CenterPoint.Y + 4);
                }
            }

            // I heard that these Dispose decrease GC time ...
            penShip.Dispose();
            penRock.Dispose();
            penRockRec.Dispose();
            penCrash.Dispose();
            penBullet.Dispose();
            fnt.Dispose();
            penLine.Dispose();
            penLineSupport.Dispose();
            g.Dispose();

            // ひだりがわだけ
            if( pic == this.pic)
            {
                Console.WriteLine("200, 200=" + canvas.GetPixel(200, 200).GetBrightness());
            }

            // Display canvas on "pic"
            pic.Image = canvas;
        }


        // picturebox のクリックをひろう
        Point sPoint = new Point(-1, -1);   // 始点
        Point ePoint = new Point(-1, -1);   // 終点
        int iLineNo = 0;                    // 線分の番号
        int iPointNo = 0;                   // 点の番号
        EntityLine entityLineTemp = null;   // 指定途中の線

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            ; // 注：MouseClickの代わりに、MouseDown()とMouseUp()で処理しています。
        }
        // MouseClickの代わりに、MouseDown()とMouseUp()で処理
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine(e.X.ToString() + "," + e.Y.ToString());
            sPoint.X = e.X;
            sPoint.Y = e.Y;
            return;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            // 線分をリストに追加
            ePoint.X = e.X;
            ePoint.Y = e.Y;
            // pic_MouseMove()と同じ処理
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (Math.Abs(ePoint.X - sPoint.X) > Math.Abs(ePoint.Y - sPoint.Y))
                {
                    // X方向の移動なので、Y固定
                    ePoint.Y = sPoint.Y;
                }
                else
                {
                    // Y方向の移動なので、X固定
                    ePoint.X = sPoint.X;
                }
            }

            if (Math.Sqrt(Math.Pow(ePoint.X - sPoint.X, 2) + Math.Pow(ePoint.Y - sPoint.Y, 2)) <= 10)    // HARD CODE 10
            {
                // 近すぎる2点は線としない
                sPoint.X = sPoint.Y = ePoint.X = ePoint.Y = -1;
                return;
            }

            Entity entLine = new EntityLine("L" + iLineNo, sPoint, ePoint);
            logic.Entitylist.Add(entLine);
            iLineNo++;

            // プログラムテスト用
            Entity ent = new Entity("P" + iPointNo, sPoint.X + 10, sPoint.Y + 10);
            logic.Entitylist.Add(ent);
            iPointNo++;

            sPoint.X = sPoint.Y = ePoint.X = ePoint.Y = -1;
            if(entityLineTemp != null)
            {
                logic.Entitylist.Remove(entityLineTemp);
            }

            return;
        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            textBoxStatus.Text = e.X.ToString() + "," + e.Y.ToString();
            if (sPoint.X >= 0 && sPoint.Y >= 0)
            {
                if (entityLineTemp != null)
                {
                    logic.Entitylist.Remove(entityLineTemp);
                }

                // 指定線を引いているので、ダミー線を追加
                // 「一時的な」線分をリストに追加
                ePoint.X = e.X;
                ePoint.Y = e.Y;
                if (Control.ModifierKeys == Keys.Shift)
                {
                    if (Math.Abs(ePoint.X - sPoint.X) > Math.Abs(ePoint.Y - sPoint.Y))
                    {
                        // X方向の移動なので、Y固定
                        ePoint.Y = sPoint.Y;
                    }
                    else
                    {
                        // Y方向の移動なので、X固定
                        ePoint.X = sPoint.X;
                    }
                }
                entityLineTemp = new EntityLine("", sPoint, ePoint);
                logic.Entitylist.Add(entityLineTemp);
                ePoint.X = ePoint.Y = -1;
            }
        }

        // Timer driven method to update picture box
        private void myTick(object sender, EventArgs e)
        {
            // Display entities in GUI
            show(pic, logic.Entitylist);
            // Display object motion
            logic.CtrlObjectMotion();   // MyDrawから呼ぶのが正しい？
            show(picObjectMotion, logic.EntitylistOM);
        }

        //
        // 以下、ボタンで駆動される処理
        //
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            logic.CtrlSort();
        }
        private void ButtonSupport_Click(object sender, EventArgs e)
        {
            logic.CtrlSupportLine();
        }
        private void ButtonObjectMotion_Click(object sender, EventArgs e)
        {
            logic.CtrlObjectMotion();
        }

        // コンソールをテキストボックスに出力するおまじない
        public class TextBoxWriter : TextWriter
        {
            TextBox _output = null;

            public TextBoxWriter(TextBox output)
            {
                _output = output;
            }

            public override void Write(char value)
            {
                base.Write(value);
                _output.AppendText(value.ToString());
            }

            public override Encoding Encoding
            {
                get { return System.Text.Encoding.UTF8; }
            }
        }

    }
}
