using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    class RectangleEx:MyShape
    {
    private double x;
        private double y;
        private double width;
        private double height;
        public RectangleEx(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw()
        {
            myGraphic.DrawRectangle(x, y, width, height);
        }
    }
}
