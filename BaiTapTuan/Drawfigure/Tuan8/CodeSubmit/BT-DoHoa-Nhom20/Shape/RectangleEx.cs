using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    class RectangleEx:MyShape, CanApplyEffectShape
    {
        private double x;
        private double y;
        private double x2;
        private double y2;
        private double width;
        private double height;
        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return null;
        }
        public RectangleEx(double X1, double Y1, double X2, double Y2)
        {
            this.x = X1;
            this.y = Y1;
            this.x2 = X2;
            this.y2 = Y2;
            Utils.ConvertToLengthAndWidth(X1, Y1, X2, Y2,out width,out height);
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            foreach (EffectShape effect in effects)
            {
                effect.ApplyEffect(this, this.ToString(), myGraphic);
            }
            //myGraphic.SetPenWidth(2);
            //myGraphic.SetPenColor(0, 0, 0);
            myGraphic.SetBrushColor(0, 0, 0);
            //Xét hướng hcn để vẽ cho đúng
            if (x < x2)
            {
                if (y < y2)
                {
                    //Từ trái trên xuống phải dưới
                    //myGraphic.DrawRectangle(x, y, width, height);
                    myGraphic.FillRectangle(x, y, width, height);
                }
                else
                {
                    //Trừ trái dưới lên phải trên
                    //myGraphic.DrawRectangle(x, y2, width, height);
                    myGraphic.FillRectangle(x, y2, width, height);
                }
            }
            else
            {
                if (y < y2)
                {
                    //Từ phải trên xuống trái dưới
                    //myGraphic.DrawRectangle(x2, y, width, height);
                    myGraphic.FillRectangle(x2, y, width, height);
                }
                else
                {
                    //Từ phải dưới lên trái trên
                    //myGraphic.DrawRectangle(x2, y2, width, height);
                    myGraphic.FillRectangle(x2, y2, width, height);
                }
            }
        }

        public override string ToString()
        {
            return "rect";
        }

        public double GetTop()
        {
            return y;
        }

        public double GetLeft()
        {
            return x;
        }

        public double GetBottom()
        {
            return y2;
        }

        public double GetRight()
        {
            return x2;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }
    }
}
