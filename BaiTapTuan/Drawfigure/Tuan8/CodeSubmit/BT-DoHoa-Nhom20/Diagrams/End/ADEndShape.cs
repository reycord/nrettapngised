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

        public ADEndShape(double X, double Y, double WIDTH, double width)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawCircle(x, y, width);
            myGraphic.FillCircle(x + width * 0.3, y + width * 0.3, width * 0.4, width * 0.4);
        }
    }
}
