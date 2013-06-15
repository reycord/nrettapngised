using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    class EclipseEx:MyShape
    {
        private double x;   //Begin X
        private double y;   //Begin Y
        private double x2;   //End X
        private double y2;   //End Y
        private double width;
        private double height;
        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return null;
        }
        public EclipseEx(double X, double Y, double WIDTH, double HEIGHT) {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.SetBrushColor(255, 69, 0);
            foreach (EffectShape effect in effects)
            {
                effect.ApplyEffect(this, this.ToString(), myGraphic);
            }
            myGraphic.SetBrushColor(0, 255, 0);
            //Xét hướng hcn để vẽ cho đúng
            if (x < width)
            {
                if (y < height)
                {
                    //Từ trái trên xuống phải dưới
                    myGraphic.FillEclipse(x, y, width, height);
                }
                else
                {
                    //Trừ trái dưới lên phải trên
                    myGraphic.FillEclipse(x, height, width, y);
                }
            }
            else
            {
                if (y < height)
                {
                    //Từ phải trên xuống trái dưới
                    myGraphic.FillEclipse(width, y, x, height);                    
                }
                else
                {
                    //Từ phải dưới lên trái trên
                    myGraphic.FillEclipse(width, height, x, y);
                }
            }
        }

        public override string ToString()
        {
            return "eclipse";
        }

        public double GetTop()
        {
            return y;
        }

        public double GetLeft()
        {
            return x;
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
