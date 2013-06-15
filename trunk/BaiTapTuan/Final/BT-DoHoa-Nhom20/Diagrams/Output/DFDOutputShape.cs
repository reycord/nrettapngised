using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class DFDOutputShape : OutputShape
    {
        private double x;
        private double y;
        private double width;
        private double height;
        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return myDiagram.CreateOutput(x, y, width, height);
        }
        public DFDOutputShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawRectangle(x, y, width, height);
            //myGraphic.DrawLine(x+5, y, height + x+5, y + height);
            myGraphic.DrawLine(x +8, y, x+8, y + height);
            myGraphic.DrawLine(x - 8 + width, y, x - 8 + width, y + height);
        }
    }
}
