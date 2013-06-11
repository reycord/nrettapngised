using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class ADProcessShape : ProcessShape
    {
       private double x;
        private double y;
        private double width;
        private double height;

        public ADProcessShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawLine(x, y, x + width * 0.15, y);
            myGraphic.DrawLine(x,y,x,y+height);
            myGraphic.DrawLine(x,y+height,x+width,y+height);
            myGraphic.DrawLine(x + width, y + height,x+width,y);
            myGraphic.DrawLine(x + width, y,x+width-width*0.15,y);
        }
    }
}
