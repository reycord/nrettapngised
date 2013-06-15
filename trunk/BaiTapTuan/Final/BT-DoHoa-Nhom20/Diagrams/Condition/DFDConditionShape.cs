using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT_DoHoa_Nhom20
{
    public class DFDConditionShape : ConditionShape
    {
        private double x;
        private double y;
        private double width;
        private double height;
        public override Shape.MyShape Clone(Diagram myDiagram)
        {
            return myDiagram.CreateCondition(x, y, width, height);
        }
        public DFDConditionShape(double X, double Y, double WIDTH, double HEIGHT)
        {
            this.x = X;
            this.y = Y;
            this.width = WIDTH;
            this.height = HEIGHT;
        }
        public override void Draw(GraphicLibExt myGraphic)
        {
            
        }
    }
}
