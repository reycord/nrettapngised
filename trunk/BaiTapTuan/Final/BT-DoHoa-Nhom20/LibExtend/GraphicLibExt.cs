using System;


namespace BT_DoHoa_Nhom20
{
    public abstract class GraphicLibExt
    {
        public abstract void DrawLine(double x1, double y1, double x2, double y2);

        public abstract void DrawEclipse(double x1, double y1, double x2, double y2);

        public abstract void DrawRectangle(double x, double y, double width, double height);

        public abstract void DrawArrow(double x1, double y1, double x2, double y2);// vẽ hình mũi tên

        public abstract void DrawText(string text, double x, double y); // chữ trong hình

        public abstract void DrawRhomb(double x, double y, double width, double height);// vẽ hình thoi

        public abstract void DrawParallelogram(double x, double y, double width, double height); // vẽ hình bình hành

        public abstract void DrawPentagonal(double x, double y, double width, double height); //vẽ hình có 5 cạnh

        public abstract void FillCircle(double x, double y, double width, double height);// to hinh tron

        public abstract void DrawCircle(double x, double y, double width); // ve hinh tron

        public abstract void SetBrushColor(int r, int g, int b);
        public abstract void SetPenColor(int r, int g, int b);
        public abstract void SetPenWidth(int w);
        public abstract string GetDescription();
    }
}
