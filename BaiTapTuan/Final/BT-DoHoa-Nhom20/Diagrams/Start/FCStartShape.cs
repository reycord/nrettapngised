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

        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return myDiagram.CreateStart(x, y, width, height);
        }
        public FCStartShape(double X, double Y, double WIDTH, double HEIGHT)
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
            //ve chu start o giua
            double xText = 0;
            double yText = 0;
            Utils.ConvertToLengthAndWidth(x, y, width, height, out yText, out xText);

            myGraphic.DrawText("Start", x + xText / 3, y + yText / 3);
        }
    }
}
