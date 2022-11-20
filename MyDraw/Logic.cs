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
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyDraw
{
    // 内部操作用の構造体
    class EntityLineForSort
    {
        internal EntityLine entityLine; // 線分
        internal double dRad;           // 角度
    };

    class Logic
    {
        // 描画する方のリスト
        public List<Entity> Entitylist { get; set; }
        // 動かす方のリスト
        public List<Entity> EntitylistOM { get; set; }
        public int iObjectMotionCntDiff = 1;   // 1 Tickで動かす個数


        private double[,] dHeat = new double[Constant.CANVAS_SIZE_X, Constant.CANVAS_SIZE_Y];

        public Logic()
        {
            Entitylist = new List<Entity>();
            EntitylistOM = new List<Entity>();
        }

        //
        // ユーザ操作から呼ばれる処理
        //
        public void CtrlSort()
        {
            Entitylist = Sort(Entitylist);
        }

        public void CtrlSupportLine()
        {
            Entitylist = AddSupportLine(Entitylist);
        }


        public List<Entity> Sort(IReadOnlyList<Entity> entityListIn)
        {
            // 最終結果のリスト
            List<Entity> entityListOut = new List<Entity>();
            // 線分ソート用のリスト
            List<EntityLineForSort> entityLinesForSortList = new List<EntityLineForSort>();

            foreach (Entity ent in entityListIn)
            {
                // 線分
                if (ent.GetType() == typeof(EntityLine))
                {
                    EntityLineForSort entForSort = new EntityLineForSort();
                    entForSort.dRad = 
                        Math.Atan2((double)(- (ent.CenterPoint.Y - Constant.CANVAS_CENTER_Y)) /* REVISIT ここでYを反転したけど、後で変更するかも */,
                                   (double)(   ent.CenterPoint.X - Constant.CANVAS_CENTER_X));
                    // Console.WriteLine(entForSort.dRad);
                    // 線分を覚えておく
                    entForSort.entityLine = (EntityLine)ent;
                    entityLinesForSortList.Add(entForSort);
                    // entityListには線分を足さずに、後で足す
                    // entityList.Add(ent);

                    // StartとEndがCCWになるようにする
                    bool doSwap = false;
                    double dRadStart, dRadEnd;
                    dRadStart =
                        Math.Atan2((double)(-(((EntityLine)ent).StartPoint.Y - Constant.CANVAS_CENTER_Y)) /* REVISIT ここでYを反転したけど、後で変更するかも */,
                                   (double)(  ((EntityLine)ent).StartPoint.X - Constant.CANVAS_CENTER_X));
                    dRadEnd =
                        Math.Atan2((double)(-(((EntityLine)ent).EndPoint.Y - Constant.CANVAS_CENTER_Y)) /* REVISIT ここでYを反転したけど、後で変更するかも */,
                                   (double)(  ((EntityLine)ent).EndPoint.X - Constant.CANVAS_CENTER_X));
                    if (dRadEnd - dRadStart <= Math.PI && dRadEnd - dRadStart >= -Math.PI)
                    {
                        if (dRadEnd - dRadStart >= 0)
                        {
                            doSwap = false;
                        }
                        else
                        {
                            doSwap = true;
                        }
                    }
                    else if (dRadEnd - dRadStart > Math.PI)
                    {
                        doSwap = true;
                    } else // if ( dRadEnd - dRadStart < -Math.PI)
                    {
                        doSwap = false; // 後で確認
                    }
                    if(doSwap)
                    {
                        Point pointTmp;

                        pointTmp = ((EntityLine)ent).EndPoint;
                        ((EntityLine)ent).EndPoint = ((EntityLine)ent).StartPoint;
                        ((EntityLine)ent).StartPoint = pointTmp;
                    }
                }
            }

            // Sort entityLine by Rad starting at PI/2 and ending at 2*PI + PI/2 (CCW starting at 0 oclock)
            IOrderedEnumerable<EntityLineForSort> entityLinesForSortOrderBy = entityLinesForSortList.OrderBy(o => o.dRad < Math.PI / 2 ? o.dRad + Math.PI * 2 : o.dRad);
            foreach (EntityLineForSort ent in entityLinesForSortOrderBy)
            {
                entityListOut.Add(ent.entityLine);
            }

            return entityListOut;
            //Console.WriteLine("Entitylist count={0}", Entitylist.Count().ToString());
        }

        // 補助線を書く
        public List<Entity> AddSupportLine(IReadOnlyList<Entity> entityListIn)
        {
            List<Entity> entityListOut = new List<Entity>();
            EntityLine entityLineLast = null;
            bool isFirstLine = true;

            foreach (Entity ent in Entitylist)
            {
                // 線分
                if (ent.GetType() == typeof(EntityLine))
                {
                    if (((EntityLine)ent).IsSupport == false)
                    {
                        if(!isFirstLine)
                        {
                            // Add support line
                            EntityLine entityLine = new EntityLine("補助線", entityLineLast.EndPoint, ((EntityLine)ent).StartPoint);
                            entityLine.IsSupport = true;
                            entityListOut.Add(entityLine);
                        }
                        // remember last orignal line
                        entityLineLast = (EntityLine)ent;
                        isFirstLine = false;
                        // Add original line
                        entityListOut.Add(ent);
                    }
                }
            }

            // Update Entitylist
            return entityListOut;
        }

        // モノを動かす
        int iObjectMotionCnt = 0;
        public void CtrlObjectMotion()
        {
            List<Entity> entityList;

            // 右側のpicture box更新タイミング？
            // 補助線以外をコピー
            entityList = new List<Entity>();
            foreach (Entity ent in Entitylist)
            {
                if (ent.GetType() == typeof(EntityLine))
                {
                    if (((EntityLine)ent).IsSupport == false)
                    {
                        entityList.Add(ent);
                    }
                }
            }
            // ソート
//            Console.WriteLine("entityList.Count() old = " + entityList.Count());
            entityList = Sort(entityList);
//            Console.WriteLine("entityList.Count() new = " + entityList.Count());
            // 補助線
            entityList = AddSupportLine(entityList);
//            Console.WriteLine("entityList.Count() after Support = " + entityList.Count());

            // 長さ
            double dentityListLength = 0.0;
            foreach (Entity ent in entityList)
            {
                dentityListLength += ((EntityLine)ent).Length;
            }

            // EntityListOMが最終成果物
            EntitylistOM = new List<Entity>();
            double dentityListOMLength = 0.0;
            foreach (Entity ent in entityList)
            {
                // 線分だけ追加
                if (ent.GetType() == typeof(EntityLine))
                {
                    if (dentityListOMLength + ((EntityLine)ent).Length <= iObjectMotionCnt)
                    {
                        Entity entPoint;
                        double dX, dY;
                        double dT;

                        dT = Math.Atan2((((EntityLine)ent).EndPoint.Y - ((EntityLine)ent).StartPoint.Y), ((EntityLine)ent).EndPoint.X - ((EntityLine)ent).StartPoint.X);
                        for (int i = 0; i < ((EntityLine)ent).Length; i++)
                        {
                            dX = Math.Cos(dT) * i + ((EntityLine)ent).StartPoint.X;
                            dY = Math.Sin(dT) * i + ((EntityLine)ent).StartPoint.Y;
                            entPoint = new Entity("", new Point((int)dX, (int)dY));
                            EntitylistOM.Add(entPoint);
                            dHeat[entPoint.CenterPoint.X, entPoint.CenterPoint.Y] += 1;
                        }

                        dentityListOMLength += ((EntityLine)ent).Length;
                    }
                    else
                    {
                        Entity entPoint;
                        double dX, dY;
                        double dT;

                        // 上と同じ処理なので、後で略すとよい
                        dT = Math.Atan2((((EntityLine)ent).EndPoint.Y - ((EntityLine)ent).StartPoint.Y), ((EntityLine)ent).EndPoint.X - ((EntityLine)ent).StartPoint.X);
                        for (int i = 0; i < (iObjectMotionCnt - dentityListOMLength); i++)
                        {
                            dX = Math.Cos(dT) * i + ((EntityLine)ent).StartPoint.X;
                            dY = Math.Sin(dT) * i + ((EntityLine)ent).StartPoint.Y;
                            entPoint = new Entity("", new Point((int)dX, (int)dY));
                            EntitylistOM.Add(entPoint);
                            dHeat[entPoint.CenterPoint.X, entPoint.CenterPoint.Y] += 1;
                        }
                        break; // foreach()
                    }
                }
            }

            // 長さ1だけ足す
            iObjectMotionCnt += iObjectMotionCntDiff;
            if (iObjectMotionCnt > dentityListLength + 1)
            {
                // 最初の線分から書き直し
                iObjectMotionCnt = 0;
            }
        }
    }
}
