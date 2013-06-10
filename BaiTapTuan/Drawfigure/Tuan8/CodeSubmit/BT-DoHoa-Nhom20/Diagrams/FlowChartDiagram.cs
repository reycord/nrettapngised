using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class FlowChart: Diagram
    {
        public override StartShape CreateStart()
        {
            return base.CreateStart();
        }

        public override ConditionShape CreateCondition()
        {
            return base.CreateCondition();
        }

        public override EndShape CreateEnd()
        {
            return base.CreateEnd();
        }

        public override InputShape CreateInput()
        {
            return base.CreateInput();
        }

        public override OutputShape CreateOutput()
        {
            return base.CreateOutput();
        }

        public override ProcessShape CreateProcess()
        {
            return base.CreateProcess();
        }

        public override TransitionShape CreateTransition()
        {
            return base.CreateTransition();
        }
    }
}
