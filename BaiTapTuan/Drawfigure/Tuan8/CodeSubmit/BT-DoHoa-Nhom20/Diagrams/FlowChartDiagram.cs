using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class FlowChart: Diagram
    {
        public override StartShape CreateStart(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new FCStartShape(X, Y, WIDTH, HEIGHT);
        }

        public override ConditionShape CreateCondition(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new FCConditionShape(X,Y,WIDTH,HEIGHT);
        }

        public override EndShape CreateEnd(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new FCEndShape(X, Y, WIDTH, HEIGHT);
        }

        public override InputShape CreateInput(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new FCInputShape(X,Y,WIDTH,HEIGHT);
        }

        public override OutputShape CreateOutput(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new FCOutputShape(X, Y, WIDTH, HEIGHT);
        }

        public override ProcessShape CreateProcess(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new FCProcessShape(X, Y, WIDTH, HEIGHT);
        }

        public override TransitionShape CreateTransition(double X1, double Y1, double X2, double Y2)
        {
            return new FCTransitionShape(X1,Y1,X2,Y2);
        }
    }
}
