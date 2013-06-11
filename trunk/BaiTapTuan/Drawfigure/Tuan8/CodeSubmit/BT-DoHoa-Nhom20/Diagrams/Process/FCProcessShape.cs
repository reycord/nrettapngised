using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class FCProcessShape : ProcessShape
    {
        private double x;
        private double y;
        private double width;
        private double height;

        public FCProcessShape(double X1, double Y1, double X2, double Y2)
        {
            this.x = X1;
            this.y = Y1;
            width = X2;
            height = Y2;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawLine(x,y,x,y+height);
            myGraphic.DrawLine(x, y + height,x+width,y+height);
            myGraphic.DrawLine(x + width, y + height,x+width,y);
        }
    }
}
