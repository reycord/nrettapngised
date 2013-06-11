using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class ADStartShape : StartShape
    {
        private double x;
        private double y;
        private double width;

        public ADStartShape(double X, double Y, double WIDTH, double Width)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawEclipse(x, y, width, width);
        }
    }
}
