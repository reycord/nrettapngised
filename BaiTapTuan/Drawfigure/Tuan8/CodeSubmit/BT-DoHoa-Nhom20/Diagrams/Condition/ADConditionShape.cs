using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class ADConditionShape : ConditionShape
    {
      private double x;
        private double y;
        private double width;
        private double height;

        public ADConditionShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            myGraphic.DrawLine(x, y + height / 2, x + width / 2, y);
            myGraphic.DrawLine(x, y + height / 2, x + width / 2, y+height);
            myGraphic.DrawLine(x+width, y + height / 2, x + width / 2, y);
            myGraphic.DrawLine(x+width, y + height / 2, x + width / 2, y + height);
        }
    }
}
