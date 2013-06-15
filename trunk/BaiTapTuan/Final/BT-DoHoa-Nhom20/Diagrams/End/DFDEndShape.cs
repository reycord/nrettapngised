using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class DFDEndShape : EndShape
    {
        private double x;
        private double y;
        private double width;
        private double height;
        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return myDiagram.CreateEnd(x, y, width, height);
        }
        public DFDEndShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawCircle(x, y, Math.Abs(width - x));
            myGraphic.DrawText("N", x + Math.Abs(width - x) / 2 - 8, y + Math.Abs(height - y) / 2 - 8);
        }
    }
}
