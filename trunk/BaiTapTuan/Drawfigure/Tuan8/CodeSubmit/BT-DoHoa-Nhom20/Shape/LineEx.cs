using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    class LineEx:MyShape, CanApplyEffectShape
    {
        private double x1;
        private double x2;
        private double y1;
        private double y2;
        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return null;
        }
        public LineEx() {
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = 0;
        }
        public LineEx(double X1, double Y1, double X2, double Y2) {
            this.x1 = X1;
            this.x2 = X2;
            this.y1 = Y1;
            this.y2 = Y2;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            //Vẽ tất cả các effect ra 
            myGraphic.SetPenColor(255, 69, 0);
            foreach (EffectShape effect in effects)
            {
                effect.ApplyEffect(this, this.GetDescription(), myGraphic);
            }
            myGraphic.SetPenWidth(2);
            myGraphic.SetPenColor(0, 255, 0);
            myGraphic.DrawLine(x1, y1, x2, y2);
        }
        
        public double GetTop()
        {
            return y1;
        }

        public double GetLeft()
        {
            return x1;
        }

        public double GetWidth()
        {
            return Math.Abs(x1 - x2);
        }

        public double GetHeight()
        {
            return Math.Abs(y1 - y2);
        }

        public string GetDescription()
        {
            return "Line";
        }

        public double GetBottom()
        {
            return y2;
        }

        public double GetRight()
        {
            return x2;
        }

        public override string ToString()
        {
            return "line";
        }
    }
}
