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
            // Console.WriteLine()先を入れ替える
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Display all the entities on the Form1.pic
        /// </summary>
        private void show()
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
            Font fnt = new Font("Arial", 12);
            Pen penLine = new Pen(Color.White, 1);

#if false
            // ぐりぐり回転はうまくいっていない
            g.ResetTransform();
            g.TranslateTransform((float)myship.xpos, (float)myship.ypos);
            g.RotateTransform( (float) ((-myship.head_theta / Math.PI) * 180) - 90 /* look up */);
            g.TranslateTransform(-(float)myship.xpos, -(float)myship.ypos);
#endif

            g.DrawRectangle(
                penRock,
                (int)100, (int)100, 4 /* w */, 4 /* h */);


            g.DrawEllipse(penBullet, 200, 200, 3 /* w */, 3 /* h */);
            

            g.DrawLine(penShip,
                (float)50,
                (float)200,
                (float)(50 + 10 * Math.Cos(1.0)),
                (float)(200 + 10 * Math.Sin(1.0))
                );
            g.DrawString("MyShip", fnt, Brushes.White,
                (float)50.0 + 8, (float)200 + 8);

            foreach(Entity ent in logic.entitylist)
            {
                // 各クラスにDrawさせてもよいが、描画はここで一元管理
                if(ent.GetType() == typeof(EntityLine))
                {
                    g.DrawLine(penLine, ((EntityLine)ent).StartPoint, ((EntityLine)ent).EndPoint);
                }
                else if(ent.GetType() == typeof(Entity))
                {
                    g.DrawEllipse(penBullet, ent.StartPoint.X, ent.StartPoint.Y, 3 /* w */, 3 /* h */);
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
            g.Dispose();

            // Display canvas on "pic"
            pic.Image = canvas;
        }

        Point sPoint = new Point(-1, -1);   // 始点
        Point ePoint = new Point(-1, -1);   // 終点
        // picturebox のクリックをひろう
        private void pic_MouseClick(object sender, MouseEventArgs e)
        {

            Console.WriteLine(e.X.ToString() + "," + e.Y.ToString());
            if (sPoint.X == -1 && sPoint.Y == -1)
            {
                sPoint.X = e.X;
                sPoint.Y = e.Y;
                return;
            }
            if (ePoint.X == -1 && ePoint.Y == -1)
            {
                //                string routestr;

                // 線分をリストに追加
                ePoint.X = e.X;
                ePoint.Y = e.Y;

                Entity entLine = new EntityLine(sPoint, ePoint);
                logic.entitylist.Add(entLine);
                // プログラムテスト用
                Entity ent = new Entity(sPoint.X + 10, sPoint.Y + 10);
                logic.entitylist.Add(ent);

                sPoint.X = sPoint.Y = ePoint.X = ePoint.Y = -1;


                return;
            }
        }

        /// <summary>
        /// Move entities in elist
        /// </summary>
        /// <param name="sender">Event sender (not used)</param>
        /// <param name="e">Event (not used)</param>
        private void myTick(object sender, EventArgs e)
        {
            // Display entities in GUI
            show();
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
