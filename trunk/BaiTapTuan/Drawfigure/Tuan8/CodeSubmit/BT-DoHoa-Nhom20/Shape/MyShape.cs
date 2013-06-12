using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    public abstract class MyShape
    {
        public abstract void Draw(GraphicLibExt myGraphic);
        public abstract MyShape Clone(Diagram myDiagram);
    }
}
