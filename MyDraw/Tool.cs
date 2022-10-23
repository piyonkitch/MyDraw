using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDraw
{
    internal class Tool
    {
        // 内部操作用の関数
        // (1,0)が0の(-PI..PI)から(0,1)が0の[0..2*PI)に変換
        internal static double dRadToRadNCcw(double dRad)
        {
            if (dRad > Math.PI / 2)
            {
                return dRad - Math.PI / 2;
            }
            else
            {
                return dRad - Math.PI / 2 + Math.PI * 2;
            }
        }
    }
}
