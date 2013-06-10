using System;


namespace BT_DoHoa_Nhom20
{
    public abstract class GraphicLibExt
    {
        public abstract void DrawLine(double x1, double y1, double x2, double y2);

        public abstract void DrawEclipse(double x, double y, double width, double height);

        public abstract void DrawRectangle(double x, double y, double width, double height);

        public abstract void DrawArrow();

        public abstract void DrawText(string text, double x, double y);
    }
}
