using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class FCInputShape : InputShape
    {
        private double x;
        private double y;
        private double width;
        private double height;

        public FCInputShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawLine(x, y + height, x + width, y + height);
            myGraphic.DrawLine(x, y + height, x + width * 0.15, y);
            myGraphic.DrawLine(x + width, y + height, x + width + width * 0.15, y);
            myGraphic.DrawLine(x + width * 0.15, y, x + width + width * 0.15, y);
        }
    }
}
