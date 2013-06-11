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
        private double height;

        public ADStartShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            //myGraphic.DrawEclipse(x, y, width, width);
            double distance = Utils.distance(x,y,width,height);
            myGraphic.FillCircle(x, y, distance , distance);
        }
    }
}
