using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    public abstract class MyShape
    {
        protected List<EffectShape> effects = new List<EffectShape>();

        public abstract void Draw(GraphicLibExt myGraphic);
        public abstract MyShape Clone(Diagram myDiagram);
        public void attachEffect(EffectShape effect)
        {
            for(int i = 0; i < effects.Count; i++)
                if (effects[i].ToString().Equals(effect.ToString())) //Đã có effect trong này
                    return;
            effects.Add(effect);
        }

        public void detachEffect(EffectShape effect)
        {
            if(effects.IndexOf(effect) >= 0)
                effects.Remove(effect);
        }
    }
}
