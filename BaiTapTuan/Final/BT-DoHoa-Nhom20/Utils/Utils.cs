﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class Utils
    {
        public static void ConvertToLengthAndWidth(double x1, double y1, double x2, double y2,out double height,out double width) {
            height = Math.Abs(x2 - x1);
            width = Math.Abs(y2 - y1);
        }

        public static double distance(double x1, double y1, double x2, double y2)
        {
            double a;
            a = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return a;
        }
    }
}
