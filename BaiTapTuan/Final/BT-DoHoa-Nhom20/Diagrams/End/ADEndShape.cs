using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class ADEndShape : EndShape
    {
        private double x;
        private double y;
        private double width;
        private double height;
        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return myDiagram.CreateEnd(x, y, width, height);
        }
        public ADEndShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawCircle(x, y, Math.Abs(width-x));
            myGraphic.FillCircle(x + Math.Abs(width - x) * 0.3, y + Math.Abs(width - x) * 0.3, Math.Abs(width - x) * 0.4, Math.Abs(width - x) * 0.4);
        }
    }
}
