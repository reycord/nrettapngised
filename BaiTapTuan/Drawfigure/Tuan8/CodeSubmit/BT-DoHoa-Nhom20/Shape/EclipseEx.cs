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
            foreach (EffectShape effect in effects)
            {
                effect.ApplyEffect(this, this.ToString(), myGraphic);
            }
            //myGraphic.SetPenWidth(2);
            //myGraphic.SetPenColor(0, 0, 0);
            myGraphic.SetBrushColor(0, 0, 0);
            myGraphic.FillEclipse(x, y, width, height);
            //Xét hướng hcn để vẽ cho đúng
            //if (x < width)
            //{
            //    if (y < height)
            //    {
            //        //Từ trái trên xuống phải dưới
            //        myGraphic.DrawEclipse(x, y, width, height);
            //    }
            //    else
            //    {
            //        //Trừ trái dưới lên phải trên
            //        myGraphic.DrawEclipse(x, y2, width, height);
            //    }
            //}
            //else
            //{
            //    if (y < y2)
            //    {
            //        //Từ phải trên xuống trái dưới
            //        myGraphic.DrawEclipse(x2, y, width, height);
            //    }
            //    else
            //    {
            //        //Từ phải dưới lên trái trên
            //        myGraphic.DrawEclipse(x2, y2, width, height);
            //    }
            //}
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
