using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    public interface CanApplyEffectShape
    {
        double GetTop();        //x1
        double GetLeft();       //y1
        double GetBottom();     //x2
        double GetRight();      //y2
        double GetWidth();
        double GetHeight();
    }
}
