using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class ADInputShape : InputShape
    {
        private double x;
        private double y;
        private double width;
        private double height;
        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return myDiagram.CreateInput(x, y, width, height);
        }
        public ADInputShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            //myGraphic.DrawLine(x, y,x+width ,y);
            //myGraphic.DrawLine(x, y, x, y+height);
            //myGraphic.DrawLine(x + width, y,x+width,y+0.8*height);
            //myGraphic.DrawLine(x, y+height, x + width*0.8, y+ height);
            //myGraphic.DrawLine(x + width, y + 0.8 * height, x + width * 0.8, y + height);
            myGraphic.DrawPentagonal(x, y, width, height);
        }
    }
}
