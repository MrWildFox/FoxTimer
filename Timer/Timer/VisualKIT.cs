using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Timer
{
    public class VisualKIT
    {
        private Graphics g;

        public static Color activeColor = Color.Red;
        public static Color unactiveColor = Color.LightGray;
        public static int lineSize = 3;

        public void InitializeGraphics(Panel context)
        {
            g = context.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        public void DrawClockFace(Point startPoint, int size)
        {
            Pen colorPen = new Pen(unactiveColor, lineSize);

            g.DrawEllipse(colorPen, startPoint.X, startPoint.Y, size, size);
        }

        public void Clear(Color clearColor)
        {
            g.Clear(clearColor);
        }
    }
}
