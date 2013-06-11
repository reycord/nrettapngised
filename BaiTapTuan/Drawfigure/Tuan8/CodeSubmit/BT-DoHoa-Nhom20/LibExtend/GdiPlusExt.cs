using System;
using System.Drawing;

namespace BT_DoHoa_Nhom20.LibExtend
{
    public class GdiPlusExt : BT_DoHoa_Nhom20.GraphicLibExt 
    {
        Graphics g;
        Pen p;
        SolidBrush b;
        public GdiPlusExt(Graphics graphics)
        {
            g = graphics;
            p = new Pen(Brushes.AntiqueWhite);
            b = new SolidBrush(Color.White);
        }
        public override void DrawLine(double x1, double y1, double x2, double y2)
        {
            g.DrawLine(p, (int)x1, (int)y1, (int)x2, (int)y2);
        }

        public override void DrawEclipse(double x1, double y1, double x2, double y2)
        {
            double width =0;
            double height = 0;
            Utils.ConvertToLengthAndWidth(x1,y1,x2,y2,out height, out width);
            Rectangle rec = new Rectangle((int)x1, (int)y1, (int)width, (int)height);
            g.DrawEllipse(p,rec);
        }

        public override void DrawRectangle(double x, double y, double width, double height)
        {
            g.DrawRectangle(p, (int)x, (int)y, (int)width, (int)height);
        }

        public override void DrawArrow(double x1, double y1, double x2, double y2)
        {
            g.DrawLine(p, (int)x1, (int)y1, (int)x2, (int)y2);

            double rx = ((x1 - x2) * 50) / Utils.distance(x1, y1, x2, y2);
            double ry = ((y1 - y2) * 50) / Utils.distance(x1, y1, x2, y2);
            double t1 = (rx - (ry * 0.5)) / 3;
            double t2 = ((rx * 0.5) + ry) / 3;

            g.DrawLine(p,(int)(t1 + x2), (int)(t2 + y2),(int)x2, (int)y2);
            t1 = ((rx + (ry * 0.5)) / 3);
            t2 = ((-1 * (rx * 0.5) + ry) / 3);
            g.DrawLine(p, (int)(x2 + t1),(int) (y2 + t2),(int)x2, (int)y2);
        }

        public override void DrawText(string text, double x, double y)
        {
            Font font = new Font("Arial", 12);
            g.DrawString(text, font, b, (int)x, (int)y);
        }

        public override void DrawRhomb(double x, double y, double width, double height)
        {
            g.DrawLine(p,(int)x, (int)(y + height / 2),(int) (x + width / 2), (int)y);
            g.DrawLine(p, (int)x, (int)(y + height / 2), (int)(x + width / 2), (int)(y + height));
            g.DrawLine(p, (int)(x + width),(int) (y + height / 2), (int)(x + width / 2), (int)y);
            g.DrawLine(p, (int)(x + width), (int)(y + height / 2), (int)(x + width / 2), (int)(y + height));
        }

        public override void DrawParallelogram(double x1, double y1, double x2, double y2)
        {
            //DrawLine(x1,y1, )
        }

        public override void DrawPentagonal(double x, double y, double width, double height)
        {
            DrawLine(x, y, x + width, y);
            DrawLine(x, y, x, y + height);
            DrawLine(x + width, y, x + width, y + 0.8 * height);
            DrawLine(x, y + height, x + width * 0.8, y + height);
            DrawLine(x + width, y + 0.8 * height, x + width * 0.8, y + height);
        }

        public override void FillCircle(double x, double y, double width, double height)
        {
            throw new NotImplementedException();
        }
    }
}
