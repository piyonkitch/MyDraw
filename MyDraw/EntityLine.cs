using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Xml.Linq;

namespace MyDraw
{
    internal class EntityLine : Entity
    {
        public Point EndPoint { get; set; }

        // コンストラクタ
        public EntityLine(Point sPoint, Point ePoint) : base(sPoint)
        {
            base.Name = "Lx";
            this.EndPoint = ePoint;
        }
    }
}
