using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public abstract class MyEffect : Shape.MyShape
    {
        protected Shape.MyShape shape;

        public void setShape(Shape.MyShape s)
        {
            this.shape = s;
        }

        public Shape.MyShape getShape()
        {
            return this.shape;
        }

        public abstract void attach(GraphicLibExt g);

        public abstract void detach(GraphicLibExt g);

        public override void Draw(GraphicLibExt myGraphic)
        {
            if (shape != null)
            {
                attach(myGraphic);
                shape.Draw(myGraphic);
            }
        }

        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            throw new NotImplementedException();
        }
    }
}
