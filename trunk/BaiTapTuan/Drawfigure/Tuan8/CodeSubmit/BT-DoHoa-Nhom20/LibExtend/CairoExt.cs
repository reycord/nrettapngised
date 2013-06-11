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
        
        }
        public override void DrawLine(double x1, double y1, double x2, double y2)
        {
            c.Color = new Color(1,1,1);
            c.MoveTo(x1, y1);
            c.LineTo(x2, y2);
            c.Stroke();
        }

        public override void DrawEclipse(double x1, double y1, double x2, double y2)
        {
            c.SetSourceRGB(1, 1, 1);  
            double cx = x1 + (Math.Abs(x2 - x1)) / 2;
            double cy = y1 + (Math.Abs(y2 - y1)) / 2;
            double width, height;
            Utils.ConvertToLengthAndWidth(x1, y1, x2, y2, out width, out height);
            c.Save();
            c.LineWidth = 0.02;
            c.Translate(cx, cy);
            c.Scale(width/2.0, height/2.0);
            c.Arc(0.0, 0.0, 1.0, 0.0, 2 * Math.PI);
            c.Stroke();
            c.ClosePath();            
            c.Restore();           
        }

        public override void DrawRectangle(double x, double y, double width, double height)
        {
            c.Color = new Color(1, 1, 1);
            c.Rectangle(x, y, width, height);
            c.Stroke();
        }

        public override void DrawArrow(double x1, double y1, double x2, double y2)
        {
            throw new NotImplementedException();
        }

        public override void DrawText(string text, double x, double y)
        {
            c.SelectFontFace("Arial", FontSlant.Normal, FontWeight.Normal);
            c.SetFontSize(12);
            c.MoveTo(x, y);
            c.ShowText(text);
        }

        public override void DrawRhomb(double x, double y, double width, double height)
        {
            throw new NotImplementedException();
        }

        public override void DrawParallelogram(double x, double y, double width, double height)
        {
            throw new NotImplementedException();
        }

        public override void DrawPentagonal(double x, double y, double width, double height)
        {
            throw new NotImplementedException();
        }

        public override void FillCircle(double x, double y, double width, double height)
        {
            throw new NotImplementedException();
        }
    }
}
