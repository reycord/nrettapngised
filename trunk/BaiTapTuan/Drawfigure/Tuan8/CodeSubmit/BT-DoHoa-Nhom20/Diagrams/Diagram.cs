using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public abstract class Diagram
    {
        public virtual StartShape CreateStart() 
        {
            return null;
        }

        public virtual InputShape CreateInput() 
        {
            return null;
        }

        public virtual OutputShape CreateOutput() 
        {
            return null;
        }

        public virtual ProcessShape CreateProcess() 
        {
            return null;
        }

        public virtual EndShape CreateEnd() 
        {
            return null;
        }

        public virtual TransitionShape CreateTransition() 
        {
            return null;
        }

        public virtual ConditionShape CreateCondition() 
        {
            return null;
        }
    }
}
