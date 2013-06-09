using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    class LineEx:MyShape
    {
        private double x1;
        private double x2;
        private double y1;
        private double y2;
        
        public LineEx() {
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = 0;
        }
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
