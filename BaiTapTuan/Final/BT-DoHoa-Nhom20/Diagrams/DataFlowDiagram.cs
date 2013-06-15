using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class DataFlowDiagram : Diagram
    {
        public override StartShape CreateStart(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new DFDStartShape(X, Y, WIDTH, HEIGHT);
        }

        public override ConditionShape CreateCondition(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new DFDConditionShape(X,Y,WIDTH,HEIGHT);
        }

        public override EndShape CreateEnd(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new DFDEndShape(X,Y,WIDTH,HEIGHT);
        }

        public override InputShape CreateInput(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new DFDInputShape(X, Y, WIDTH, HEIGHT);
        }

        public override OutputShape CreateOutput(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new DFDOutputShape(X,Y,WIDTH,HEIGHT);
        }

        public override ProcessShape CreateProcess(double X, double Y, double WIDTH, double HEIGHT)
        {
            return new DFDProcessShape(X, Y, WIDTH, HEIGHT);
        }

        public override TransitionShape CreateTransition(double X1, double Y1, double X2, double Y2)
        {
            return new DFDTransitionShape(X1, Y1, X2, Y2);
        }
    }
}
