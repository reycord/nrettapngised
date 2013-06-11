using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class DFDStartShape : StartShape
    {
        private double x;
        private double y;
        private double width;
        private double height;

        public DFDStartShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawCircle(x, y, width);
            myGraphic.DrawText("1", x + width / 2 - 8, y + height / 2 - 8);
        }
    }
}
