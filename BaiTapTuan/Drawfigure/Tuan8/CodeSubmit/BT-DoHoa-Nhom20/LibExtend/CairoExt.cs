using System;
using Cairo;
using Gtk;
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
            c.MoveTo(x1, y1);
            c.LineTo(x2, y2);
            c.Stroke();
        }

        public override void DrawEclipse(double x, double y, double width, double height)
        {
            c.Scale(width, height);
            c.Arc(0, 0, 0.2, 0, 2 * Math.PI);
            c.Stroke();
        }

        public override void DrawRectangle(double x, double y, double width, double height)
        {
            c.Rectangle(x, y, width, height);
            c.Stroke();
        }
    }
}
