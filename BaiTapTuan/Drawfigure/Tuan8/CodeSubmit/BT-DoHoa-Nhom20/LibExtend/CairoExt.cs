using System;
using Cairo;
using Gtk;
using BT_DoHoa_Nhom20;
namespace BT_DoHoa_Nhom20.LibExtend
{
    public class CairoExt : BT_DoHoa_Nhom20.GraphicLibExt 
    {
        Surface s;
        Context c;
        public CairoExt(IntPtr hdc)
        {
            s = new Win32Surface(hdc);
            c = new Context(s);
            c.SetSourceRGB(1, 0, 0.6);
        }
        public override void DrawLine(double x1, double y1, double x2, double y2)
        {
            //c.Color = new Color(1,0,0.6);
            c.MoveTo(x1, y1);
            c.LineTo(x2, y2);
            c.Stroke();           
        }

        public override void DrawEclipse(double x1, double y1, double x2, double y2)
        {
            //if(x1>=x2 && y1<=y2)
            //{
            //    double temp = x1;
            //    x1 = x2;
            //    x2 = temp;
            //    temp = y1;
            //    y1 = y2;
            //    y2 = temp;
            //}
            //c.SetSourceRGB(1, 0, 0.6);  
            double cx = x1 + (Math.Abs(x2 - x1)) / 2;
            double cy = y1 + (Math.Abs(y2 - y1)) / 2;
            double width, height;
            Utils.ConvertToLengthAndWidth(x1, y1, x2, y2, out width, out height);
            c.Save();
            c.LineWidth = 0.02;
            c.Translate(cx, cy);
            c.Scale(width/2.0, height/2.0);
            //c.Arc(0.0, 0.0, 1.0, 0.0, 2 * Math.PI);
            //c.Stroke();
            //c.ClosePath();            
            //c.Restore();           
            c.Arc(0.0, 0.0, 1.0, 0.0, 2 * Math.PI);
            //c.ClosePath();
            c.Stroke();            
            c.Restore();           
        }

        public override void DrawRectangle(double x, double y, double width, double height)
        {
            //c.Color = new Color(1, 0, 0.6);
            c.Rectangle(x, y, width, height);
            c.Stroke();
        }

        public override void DrawArrow(double x1, double y1, double x2, double y2)
        {
            DrawLine(x1, y1, x2, y2);

            double rx = ((x1 - x2) * 50) / Utils.distance(x1, y1, x2, y2);
            double ry = ((y1 - y2) * 50) / Utils.distance(x1, y1, x2, y2);
            double t1 = (rx - (ry * 0.5)) / 3;
            double t2 = ((rx * 0.5) + ry) / 3;

            DrawLine(t1 + x2, t2 + y2, x2, y2);
            t1 = ((rx + (ry * 0.5)) / 3);
            t2 = ((-1 * (rx * 0.5) + ry) / 3);
            DrawLine(x2 + t1, y2 + t2, x2, y2);
        }

        public override void DrawText(string text, double x, double y)
        {
            c.SelectFontFace("Arial", FontSlant.Normal, FontWeight.Normal);
            c.SetFontSize(12);
            c.MoveTo(x - x / 20, y - y / 20);
            c.ShowText(text);
            c.Stroke();
        }

        public override void DrawRhomb(double x, double y, double width, double height)
        {
            DrawLine(x, y + height / 2, x + width / 2, y);
            DrawLine(x, y + height / 2, x + width / 2, y + height);
            DrawLine(x + width, y + height / 2, x + width / 2, y);
            DrawLine(x + width, y + height / 2, x + width / 2, y + height);
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
            c.Save();
            //c.Color = new Color(1, 0, 0.6);
            c.Arc(x - width * 0.8, y - width * 0.8, width / 4.0, 0, 2 * Math.PI);
            c.FillPreserve();
            c.Stroke();
            c.Restore();
        }

        public override void DrawCircle(double x, double y, double width)
        {
            c.Save();
            //c.Color = new Color(1, 0, 0.6);
            c.Arc(x, y, width / 4.0, 0, 2 * Math.PI);
            c.Stroke();
            c.Restore();
        }

        public override void SetBrushColor(int r, int g, int b)
        {
            c.SetSourceRGB(r, g, b);
            //c.Color = new Color(r, g, b);
        }

        public override void SetPenColor(int r, int g, int b)
        {
            c.SetSourceRGB(r, g, b);           
            c.Color = new Color(r, g, b);
        }

        public override void SetPenWidth(int w)
        {                    
            c.LineWidth = w;
        }

        public override string GetDescription()
        {
            return "Cairo";
        }

        public override void FillEclipse(double x1, double y1, double x2, double y2)
        {
            throw new NotImplementedException();
        }

        public override void FillRectangle(double x, double y, double width, double height)
        {
            throw new NotImplementedException();
        }
    }
}
