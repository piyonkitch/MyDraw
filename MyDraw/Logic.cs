﻿/*
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
using System.Threading.Tasks;

namespace MyDraw
{
    // 内部操作用の構造体
    class EntityLineForSort
    {
        internal EntityLine entityLine; // 線分
        internal double dRadNCcw;       // 角度
    };

    class Logic
    {
        public List<Entity> Entitylist { get; set; }

        public Logic()
        {
            Entitylist = new List<Entity>();
        }

        //
        // ユーザ操作から呼ばれる処理
        //
        public void CtrlSort()
        {
            // 最終結果のリスト
            List<Entity> entityList = new List<Entity>();
            // 線分ソート用のリスト
            List<EntityLineForSort> entityLinesForSortList = new List<EntityLineForSort>();

            Console.WriteLine("CtrlSort() is called");

            foreach (Entity ent in Entitylist)
            {
                // 線分
                if (ent.GetType() == typeof(EntityLine))
                {
                    EntityLineForSort entForSort = new EntityLineForSort();
                    double dRad;
                    dRad = 
                        Math.Atan2((double)(- (ent.CenterPoint.Y - Constant.CANVAS_CENTER_Y)) /* REVISIT ここでYを反転したけど、後で変更するかも */,
                                   (double)(   ent.CenterPoint.X - Constant.CANVAS_CENTER_X));
                    entForSort.dRadNCcw = Tool.dRadToRadNCcw(dRad);
                    Console.WriteLine(entForSort.dRadNCcw);
                    // 線分を覚えておく
                    entForSort.entityLine = (EntityLine)ent;
                    entityLinesForSortList.Add(entForSort);
                    // entityListには線分を足さずに、後で足す
                    // entityList.Add(ent);

                    // StartとEndがCCWになるようにする
                    bool doSwap = false;
                    double dRadStart, dRadEnd;              // (1, 0)が0の角度
                    double dRadNCcwStart, dRadNCcwEnd;      // (0, 1)が0の角度
                    double dRadDiff;                        // 終点位置の中央から見た角度 - 始点位置の中央から見た角度
                    dRadStart =
                        Math.Atan2((double)(-(((EntityLine)ent).StartPoint.Y - Constant.CANVAS_CENTER_Y)) /* REVISIT ここでYを反転したけど、後で変更するかも */,
                                   (double)(  ((EntityLine)ent).StartPoint.X - Constant.CANVAS_CENTER_X));
                    dRadNCcwStart = Tool.dRadToRadNCcw(dRadStart);
                    Console.WriteLine("dRadNCcwStart=" + dRadNCcwStart);

                    dRadEnd =
                        Math.Atan2((double)(-(((EntityLine)ent).EndPoint.Y - Constant.CANVAS_CENTER_Y)) /* REVISIT ここでYを反転したけど、後で変更するかも */,
                                   (double)(  ((EntityLine)ent).EndPoint.X - Constant.CANVAS_CENTER_X));
                    dRadNCcwEnd = Tool.dRadToRadNCcw(dRadEnd);
                    Console.WriteLine("dRadNCcwEnd=" + dRadNCcwEnd);

                    dRadDiff = dRadNCcwEnd - dRadNCcwStart;
                    if(dRadDiff > Math.PI * 2)
                    {
                        dRadDiff -= Math.PI * 2;
                        Console.WriteLine("-2PI");
                    }
                    if (dRadDiff < -Math.PI * 2)
                    {
                        dRadDiff += Math.PI * 2;
                        Console.WriteLine("+2PI");
                    }

                    Console.WriteLine("dRadNCcwEnd-dRadNCcwwStart=" + dRadDiff.ToString());
                    if ((dRadDiff > 0) && (dRadDiff <= Math.PI))
                    {
                        doSwap = false;
                    }
                    else if ((dRadDiff < 0) && (dRadDiff <= -Math.PI))
                    {
                        doSwap = false;
                    }
                    else
                    {
                        doSwap = true;
                    }
                    if(doSwap)
                    {
                        Point pointTmp;

                        pointTmp = ((EntityLine)ent).EndPoint;
                        ((EntityLine)ent).EndPoint = ((EntityLine)ent).StartPoint;
                        ((EntityLine)ent).StartPoint = pointTmp;
                    }
                }
                // 点
                else if (ent.GetType() == typeof(Entity))
                {
                    entityList.Add(ent);
                }
            }

            // 線分をソート
            IOrderedEnumerable<EntityLineForSort> entityLinesForSortOrderBy = entityLinesForSortList.OrderBy(o => o.dRadNCcw);
            foreach (EntityLineForSort ent in entityLinesForSortOrderBy)
            {
                entityList.Add(ent.entityLine);
                //Console.WriteLine("Rad =" + ent.dRad);
            }

            // Update Entitylist
            Entitylist = entityList;
            //Console.WriteLine("Entitylist count={0}", Entitylist.Count().ToString());
        }

        // 補助線を書く
        public void CtrlSupportLine()
        {
            List<Entity> entityList = new List<Entity>();
            EntityLine entityLineLast = null;
            bool isFirstLine = true;

            Console.WriteLine("CtrlSupportLine() is called");

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
                            entityList.Add(entityLine);
                        }
                        // remember last orignal line
                        entityLineLast = (EntityLine)ent;
                        isFirstLine = false;
                        // Add original line
                        entityList.Add(ent);
                    }
                }
                // 点
                else if (ent.GetType() == typeof(Entity))
                {
                    entityList.Add(ent);
                }
            }

            // Update Entitylist
            Entitylist = entityList;
            Console.WriteLine("Entitylist count={0}", Entitylist.Count().ToString());
        }
    }
}
