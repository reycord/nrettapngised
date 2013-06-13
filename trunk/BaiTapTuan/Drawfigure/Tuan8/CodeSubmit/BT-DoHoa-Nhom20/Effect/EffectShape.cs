using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BT_DoHoa_Nhom20.Shape;

namespace BT_DoHoa_Nhom20
{
    public interface EffectShape
    {
        void ApplyEffect(MyShape shape, string type, GraphicLibExt myGraphic);
        string ToString();
    }
}
