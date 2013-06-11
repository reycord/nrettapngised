﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class FCEndShape : EndShape
    {
        private double x;
        private double y;
        private double width;
        private double height;

        public FCEndShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }

        public override void Draw(GraphicLibExt myGraphic)
        {
            //ve hinh ellipse
            myGraphic.DrawEclipse(x, y, width, height);

            //ve chu end o giua
            myGraphic.DrawText("End", x + width/2-15,y+height/2-15);
        }
    }
}
