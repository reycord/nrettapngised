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

        public DFDEndShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawEclipse(x, y, width, height);
            myGraphic.DrawText("end", x + width / 2-10, y + height / 2-10);
        }
    }
}
