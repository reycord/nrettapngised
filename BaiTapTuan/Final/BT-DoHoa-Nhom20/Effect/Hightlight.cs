using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class Hightlight : MyEffect
    {
        public override void attach(GraphicLibExt g)
        {
            throw new NotImplementedException();
        }

        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return base.Clone(myDiagram);
        }

        public override void detach(GraphicLibExt g)
        {
            throw new NotImplementedException();
        }

        public override void Draw(GraphicLibExt myGraphic)
        {
            base.Draw(myGraphic);
        }
    }
}
