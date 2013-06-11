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
            return null;
        }

        public override ConditionShape CreateCondition(double X, double Y, double WIDTH, double HEIGHT)
        {
            return null;
        }

        public override EndShape CreateEnd(double X, double Y, double WIDTH, double HEIGHT)
        {
            return null;
        }

        public override InputShape CreateInput(double X, double Y, double WIDTH, double HEIGHT)
        {
            return null;
        }

        public override OutputShape CreateOutput(double X, double Y, double WIDTH, double HEIGHT)
        {
            return null;
        }

        public override ProcessShape CreateProcess(double X, double Y, double WIDTH, double HEIGHT)
        {
            return null;
        }

        public override TransitionShape CreateTransition(double X1, double Y1, double X2, double Y2)
        {
            return null;
        }
    }
}
