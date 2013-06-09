using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    public class MyShape
    {
        protected GraphicLibExt myGraphic;

        public GraphicLibExt MyGraphic{
            set { myGraphic = value; }
        }
        public virtual void Draw() { }
    }
}
