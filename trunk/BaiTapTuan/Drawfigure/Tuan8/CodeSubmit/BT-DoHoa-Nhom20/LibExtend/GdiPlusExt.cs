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
            p = new Pen(Brushes.OrangeRed);
            b = new SolidBrush(Color.Red);
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
            Rectangle rec = new Rectangle((int)x1, (int)y1, (int)height, (int)width);
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
            Font font = new Font("Arial", 10);
            g.DrawString(text, font, b, (int)x, (int)y);
        }

        public override void DrawRhomb(double x, double y, double width, double height)
        {
            g.DrawLine(p,(int)x, (int)(y + height / 2),(int) (x + width / 2), (int)y);
            g.DrawLine(p, (int)x, (int)(y + height / 2), (int)(x + width / 2), (int)(y + height));
            g.DrawLine(p, (int)(x + width),(int) (y + height / 2), (int)(x + width / 2), (int)y);
            g.DrawLine(p, (int)(x + width), (int)(y + height / 2), (int)(x + width / 2), (int)(y + height));
        }

        public override void DrawParallelogram(double x, double y, double width, double height)
        {
            DrawLine(x, y + height, x + width, y + height);
            DrawLine(x, y + height, x + width * 0.15, y);
            DrawLine(x + width, y + height, x + width + width * 0.15, y);
            DrawLine(x + width * 0.15, y, x + width + width * 0.15, y);
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
            g.FillEllipse(Brushes.Black, (int)x, (int)y, (int)width, (int)width);
        }

        public override void DrawCircle(double x, double y, double width)
        {
            g.DrawEllipse(p, (int)x, (int)y, (int)width, (int)width);
        }

        public override void SetBrushColor(int _r, int _g, int _b)
        {
            b.Color = Color.FromArgb(_r, _g, _b);
        }

        public override void SetPenColor(int _r, int _g, int _b)
        {
            p.Color = Color.FromArgb(_r, _g, _b);
        }

        public override void SetPenWidth(int w)
        {
            p.Width = w;
        }

        public override string GetDescription()
        {
            return "gdi";
        }

        public override void FillEclipse(double x1, double y1, double x2, double y2)
        {
            double width = 0;
            double height = 0;
            Utils.ConvertToLengthAndWidth(x1, y1, x2, y2, out height, out width);
            Rectangle rec = new Rectangle((int)x1, (int)y1, (int)height, (int)width);
            g.FillEllipse(b, rec);
        }

        public override void FillRectangle(double x, double y, double width, double height)
        {
            g.FillRectangle(b, (int)x, (int)y, (int)width, (int)height);
        }
    }
}
