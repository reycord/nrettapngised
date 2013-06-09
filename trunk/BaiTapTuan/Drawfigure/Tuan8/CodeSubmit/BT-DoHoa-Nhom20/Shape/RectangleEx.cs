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

        public RectangleEx(double X1, double Y1, double X2, double Y2)
        {
            this.x = X1;
            this.y = Y1;
            Utils.ConvertToLengthAndWidth(X1, Y1, X2, Y2,out width,out height);
        }
        public override void Draw()
        {
            myGraphic.DrawRectangle(x, y, width, height);
        }
    }
}
