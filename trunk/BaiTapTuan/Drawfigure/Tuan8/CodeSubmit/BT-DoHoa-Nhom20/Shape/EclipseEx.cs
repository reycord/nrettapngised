using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20.Shape
{
    class EclipseEx:MyShape
    {
        private double x;
        private double y;
        private double width;
        private double height;
        public EclipseEx(double X, double Y, double WIDTH, double HEIGHT) {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw()
        {
            myGraphic.DrawEclipse(x, y, width, height);
        }
    }
}
