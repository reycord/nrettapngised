using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class FCTransitionShape : TransitionShape
    {
        private double x1;
        private double x2;
        private double y1;
        private double y2;
        public FCTransitionShape(double X1, double Y1, double X2, double Y2) 
        {
            this.x1 = X1;
            this.x2 = X2;
            this.y1 = Y1;
            this.y2 = Y2;
        }
        public double distance(double x1, double y1, double x2, double y2)
        {
            double a;
            a = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return a;
        }

        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawArrow(x1, y1, x2, y2);
        }
    }
}
