using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    class LineEx:MyShape
    {
        public double x1;
        public double x2;
        public double y1;
        public double y2;

        public LineEx(double X1, double Y1, double X2, double Y2) {
            this.x1 = X1;
            this.x2 = X2;
            this.y1 = Y1;
            this.y2 = Y2;
        }
        public override void Draw()
        {
            myGraphic.DrawLine(x1, y1, x2, y2);
        }
    }
}
