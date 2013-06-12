using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class ADTransitionShape : TransitionShape
    {
       private double x1;
        private double x2;
        private double y1;
        private double y2;
        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return myDiagram.CreateTransition(x1, y1, x2, y2);
        }
        public ADTransitionShape(double X1, double Y1, double X2, double Y2) 
        {
            this.x1 = X1;
            this.x2 = X2;
            this.y1 = Y1;
            this.y2 = Y2;
        }
        
        public override void Draw(GraphicLibExt myGraphic)
        {
            //myGraphic.DrawLine(x1, y1, x2, y2);
            
            //double rx = ((x1 - x2) * 50) / Utils.distance(x1, y1, x2, y2);
            //double ry = ((y1 - y2) * 50) / Utils.distance(x1, y1, x2, y2);
            //double t1= (rx - (ry * 0.5)) /3;
            //double t2= ((rx * 0.5) + ry)/ 3;
            //myGraphic.DrawLine(t1+x2,t2+y2 , x2, y2);
            //t1 = ((rx + (ry * 0.5)) /3);
            //t2= ( (-1*(rx * 0.5) + ry) /3);
            //myGraphic.DrawLine(x2+t1,y2+t2, x2, y2);
            myGraphic.DrawArrow(x1, y1, x2, y2);
        }
    }
}
