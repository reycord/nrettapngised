using System;
using System.Drawing;

namespace BT_DoHoa_Nhom20.LibExtend
{
    public class GdiPlusExt : BT_DoHoa_Nhom20.GraphicLibExt 
    {
        Graphics g;
        Pen p;
        public GdiPlusExt(Graphics graphics)
        {
            g = graphics;
            p = new Pen(Brushes.AntiqueWhite);
        }
        public override void DrawLine(double x1, double y1, double x2, double y2)
        {
            g.DrawLine(p, (int)x1, (int)y1, (int)x2, (int)y2);
        }

        public override void DrawEclipse(double x, double y, double width, double height)
        {
            g.DrawEllipse(p, (int)x, (int)y, (int)width, (int)height);
        }

        public override void DrawRectangle(double x, double y, double width, double height)
        {
            g.DrawRectangle(p, (int)x, (int)y, (int)width, (int)height);
        }
    }
}
