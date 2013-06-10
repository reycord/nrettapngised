using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public abstract class Diagram
    {
        public abstract StartShape CreateStart();

        public abstract InputShape CreateInput();

        public abstract OutputShape CreateOutput();

        public abstract ProcessShape CreateProcess();

        public abstract EndShape CreateEnd();

        public abstract TransitionShape CreateTransition() ;

        public abstract ConditionShape CreateCondition() ;
    }
}
