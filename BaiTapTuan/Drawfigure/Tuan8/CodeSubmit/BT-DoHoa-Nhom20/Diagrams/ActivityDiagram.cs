using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class ActivityDiagram : Diagram
    {
        public override StartShape CreateStart(double X, double Y, double WIDTH, double width)
        {
            return new ADStartShape(X, Y, WIDTH, width);
        }

        public override ConditionShape CreateCondition(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new ADConditionShape(X, Y, WIDTH, HEIGHT);
        }

        public override EndShape CreateEnd(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new ADEndShape(X, Y, WIDTH, HEIGHT);
        }

        public override InputShape CreateInput(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new ADInputShape(X, Y, WIDTH, HEIGHT);
        }

        public override OutputShape CreateOutput(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new ADOutputShape(X, Y, WIDTH, HEIGHT);
        }

        public override ProcessShape CreateProcess(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new ADProcessShape(X, Y, WIDTH, HEIGHT);
        }

        public override TransitionShape CreateTransition(double X1, double Y1, double X2, double Y2)
        {
            return new ADTransitionShape(X1,Y1,X2,Y2);
        }
    }
}
