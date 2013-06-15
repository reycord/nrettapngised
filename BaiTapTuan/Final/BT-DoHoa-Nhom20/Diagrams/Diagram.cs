using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public abstract class Diagram
    {
        public abstract StartShape CreateStart(double X, double Y, double WIDTH, double HEIGHT);

        public abstract InputShape CreateInput(double X, double Y, double WIDTH, double HEIGHT);

        public abstract OutputShape CreateOutput(double X, double Y, double WIDTH, double HEIGHT);

        public abstract ProcessShape CreateProcess(double X, double Y, double WIDTH, double HEIGHT);

        public abstract EndShape CreateEnd(double X, double Y, double WIDTH, double HEIGHT);

        public abstract TransitionShape CreateTransition(double X1, double Y1, double X2, double Y2);

        public abstract ConditionShape CreateCondition(double X, double Y, double WIDTH, double HEIGHT);
    }
}
