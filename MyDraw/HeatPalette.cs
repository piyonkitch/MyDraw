using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDraw
{
    internal class HeatPalette
    {
        public Color[] colors = new Color[512];

        public HeatPalette()
        {
            for (int i = 0; i < 512; i++)
            {
                int tmp = Math.Min(i, 511);

                int tmpR = (tmp < 128) ? 0 : Math.Min(tmp - 128, 255);
                int tmpG = (tmp < 256) ? tmp : Math.Min(511 - tmp, 255);
                int tmpB = 0;
                colors[i] = Color.FromArgb(tmpR, tmpG, tmpB);
            }
        }

        public void SetPictureBox(PictureBox pic)
        {
            Bitmap canvas = new Bitmap(pic.Width, pic.Height);
            for(int x = 0; x < Math.Min(255, pic.Width); x++)
            {
                canvas.SetPixel(x, 0, colors[x * 2]);
            }

            pic.Image = canvas;
        }
    }
}
