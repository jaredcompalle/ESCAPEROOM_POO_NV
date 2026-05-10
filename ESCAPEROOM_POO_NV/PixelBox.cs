using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCAPEROOM_POO_NV
{
    public class PixelBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            // Forzamos el modo de dibujo pixelado
            paintEventArgs.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            paintEventArgs.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            base.OnPaint(paintEventArgs);
        }
    }
}
