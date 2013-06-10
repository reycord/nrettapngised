﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class FCStartShape : StartShape
    {
        private double x;
        private double y;
        private double width;
        private double height;

        public FCStartShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }

        public override void Draw()
        {
            //ve hinh ellipse
            myGraphic.DrawEclipse(x, y, width, height);

            //ve chu start o giua
            myGraphic.DrawText("Start", x + x * 2/5, y * 2);
        }
    }
}
