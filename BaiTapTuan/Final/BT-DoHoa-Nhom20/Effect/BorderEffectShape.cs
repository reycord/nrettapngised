using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BT_DoHoa_Nhom20.Shape;

namespace BT_DoHoa_Nhom20
{
    public class BorderEffectShape : EffectShape
    {
        public void ApplyEffect(MyShape shape, string shapeType, GraphicLibExt myGraphic)
        {
            double x1, x2, y1, y2, w, h;
            switch (shapeType)
            {
                case "Line":
                    //Vẽ 2 hình tròn nhỏ ở 2 đầu
                    LineEx temp = (LineEx)shape;
                    x1 = temp.GetLeft();
                    x2 = temp.GetRight();
                    y1 = temp.GetTop();
                    y2 = temp.GetBottom();
                    myGraphic.DrawCircle(x1, y1, 5);
                    myGraphic.DrawCircle(x2, y2, 5);
                    break;
                case "rect":
                    //Vẽ các hình tròn và vuông ở các góc vào trung điểm các cạnh
                    RectangleEx tempRect = (RectangleEx)shape;
                    x1 = tempRect.GetLeft();
                    y1 = tempRect.GetTop();
                    x2 = tempRect.GetRight();
                    y2 = tempRect.GetBottom();
                    w = tempRect.GetWidth();
                    h = tempRect.GetHeight();
                    //Vẽ 4 góc = hình tròn
                    myGraphic.DrawCircle(x1, y1, 5);
                    myGraphic.DrawCircle(x1, y2, 5);
                    myGraphic.DrawCircle(x2, y1, 5);
                    myGraphic.DrawCircle(x2, y2, 5);
                    //Xét hướng vẽ của hình để vẽ các trung điểm chính xác = hình vuông
                    if (x1 < x2)    //Vẽ từ trái qua phải
                    {
                        myGraphic.DrawRectangle(x1 + w / 2, y1, 5, 5);
                        myGraphic.DrawRectangle(x1 + w / 2, y2, 5, 5);
                        if (y1 < y2)
                        {
                            myGraphic.DrawRectangle(x1, y1 + h / 2, 5, 5);
                            myGraphic.DrawRectangle(x2, y1 + h / 2, 5, 5);
                        }
                        else
                        {
                            myGraphic.DrawRectangle(x1, y2 + h / 2, 5, 5);
                            myGraphic.DrawRectangle(x2, y2 + h / 2, 5, 5);
                        }
                    }
                    else
                    {
                        myGraphic.DrawRectangle(x2 + w / 2, y1, 5, 5);
                        myGraphic.DrawRectangle(x2 + w / 2, y2, 5, 5);
                        if (y1 < y2)
                        {
                            myGraphic.DrawRectangle(x1, y1 + h / 2, 5, 5);
                            myGraphic.DrawRectangle(x2, y1 + h / 2, 5, 5);
                        }
                        else
                        {
                            myGraphic.DrawRectangle(x1, y2 + h / 2, 5, 5);
                            myGraphic.DrawRectangle(x2, y2 + h / 2, 5, 5);
                        }
                    }
                    break;
                case "eclipse":
                    //Vẽ các hình tròn và vuông ở các góc vào trung điểm các cạnh
                    EclipseEx tempEclipse = (EclipseEx)shape;
                    x1 = tempEclipse.GetLeft();
                    y1 = tempEclipse.GetTop();
                    //x2 = tempEclipse.GetRight();
                    //y2 = tempEclipse.GetBottom();
                    w = tempEclipse.GetWidth();
                    h = tempEclipse.GetHeight();

                    //Chỉ áp dụng được trên hình vẽ từ trên trái sang phải dưới
                    myGraphic.DrawCircle(x1, y1, 5);
                    myGraphic.DrawCircle(x1, h, 5);
                    myGraphic.DrawCircle(w, h, 5);
                    myGraphic.DrawCircle(w, y1, 5);

                    myGraphic.DrawRectangle(x1 + Math.Abs(x1 - w) / 2, y1, 5, 5);
                    myGraphic.DrawRectangle(x1 + Math.Abs(x1 - w) / 2, h, 5, 5);
                    myGraphic.DrawRectangle(x1, y1 + Math.Abs(h - y1) / 2, 5, 5);
                    myGraphic.DrawRectangle(w, y1 + Math.Abs(h - y1) / 2, 5, 5);

                    ////Xét hướng vẽ của hình để vẽ các trung điểm chính xác = hình vuông
                    //if (x1 < x2)    //Vẽ từ trái qua phải
                    //{
                    //    myGraphic.DrawRectangle(x1 + w / 2, y1, 5, 5);
                    //    myGraphic.DrawRectangle(x1 + w / 2, y2, 5, 5);
                    //    if (y1 < y2)
                    //    {
                    //        myGraphic.DrawRectangle(x1, y1 + h / 2, 5, 5);
                    //        myGraphic.DrawRectangle(x2, y1 + h / 2, 5, 5);
                    //    }
                    //    else
                    //    {
                    //        myGraphic.DrawRectangle(x1, y2 + h / 2, 5, 5);
                    //        myGraphic.DrawRectangle(x2, y2 + h / 2, 5, 5);
                    //    }
                    //}
                    //else
                    //{
                    //    myGraphic.DrawRectangle(x2 + w / 2, y1, 5, 5);
                    //    myGraphic.DrawRectangle(x2 + w / 2, y2, 5, 5);
                    //    if (y1 < y2)
                    //    {
                    //        myGraphic.DrawRectangle(x1, y1 + h / 2, 5, 5);
                    //        myGraphic.DrawRectangle(x2, y1 + h / 2, 5, 5);
                    //    }
                    //    else
                    //    {
                    //        myGraphic.DrawRectangle(x1, y2 + h / 2, 5, 5);
                    //        myGraphic.DrawRectangle(x2, y2 + h / 2, 5, 5);
                    //    }
                    //}
                    break;
            }
        }

        public BorderEffectShape()
        {

        }

        //public override void Draw(GraphicLibExt myGraphic)
        //{
        //    //Vẽ lõi trước - dùng switch case để biết lõi thuộc loại hình gì
        //    /*
        //     * Vẽ effect = các hình tròn và vuông ở các góc và giao điểm các cạnh hình chữ nhật bọc bên ngoài core (8 điểm). Như sau
        //     * 
        //     * 1----2----3
        //     * |         |
        //     * 8         4
        //     * |         |
        //     * 7----6----5
        //     * 
        //     * Trong đó 1 3 5 7 là hình tròn, 2 4 6 8 là hình vuông
        //     */
        //    double x1, x2, x3, x4, x5, x6, x7, x8, y1, y2, y3, y4, y5, y6, y7, y8;
        //    switch (core.GetDescription())
        //    {
        //        case "Line":
        //            ((LineEx)core).Draw(myGraphic);
        //            x1 = core.GetLeft();
        //            x2 = x1 + core.GetWidth();
        //            y1 = core.GetTop();
        //            y2 = y1 + core.GetHeight();
        //            myGraphic.DrawCircle(x1 - 3, y1 - 3, 7);
        //            myGraphic.DrawCircle(x2 - 3, y2 - 3, 7);
        //            break;
        //        case "Rectangle":
        //            ((RectangleEx)core).Draw(myGraphic);
        //            x1 = x7 = x8 = core.GetLeft(); 
        //            x3 = x4 = x5 = x1 + core.GetWidth();
        //            x2 = x6 = x1 + core.GetWidth() / 2;

        //            y1 = y2 = y3 = core.GetTop();
        //            y5 = y6 = y7 = y1 + core.GetHeight();
        //            y4 = y8 = y1 + core.GetHeight() / 2;

        //            myGraphic.DrawRectangle(x2 - 3, y2 - 3, 5, 7);
        //            myGraphic.DrawRectangle(x4 - 3, y4 - 3, 5, 7);
        //            myGraphic.DrawRectangle(x6 - 3, y6 - 3, 5, 7);
        //            myGraphic.DrawRectangle(x8 - 3, y8 - 3, 5, 7);

        //            myGraphic.DrawCircle(x1 - 3, y1 - 3, 7);
        //            myGraphic.DrawCircle(x3 - 3, y3 - 3, 7);
        //            myGraphic.DrawCircle(x5 - 3, y5 - 3, 7);
        //            myGraphic.DrawCircle(x7 - 3, y7 - 3, 7);
        //            break;
        //        case "Eclipse":
        //            ((EclipseEx)core).Draw(myGraphic);
        //            x1 = x7 = x8 = core.GetLeft(); 
        //            x3 = x4 = x5 = core.GetWidth();
        //            x2 = x6 = x1 + Math.Abs(core.GetWidth() - x1) / 2;

        //            y1 = y2 = y3 = core.GetTop();
        //            y5 = y6 = y7 = core.GetHeight();
        //            y4 = y8 = y1 + Math.Abs(core.GetHeight() - y1) / 2;

        //            myGraphic.DrawRectangle(x2 - 3, y2 - 3, 5, 7);
        //            myGraphic.DrawRectangle(x4 - 3, y4 - 3, 5, 7);
        //            myGraphic.DrawRectangle(x6 - 3, y6 - 3, 5, 7);
        //            myGraphic.DrawRectangle(x8 - 3, y8 - 3, 5, 7);

        //            myGraphic.DrawCircle(x1 - 3, y1 - 3, 7);
        //            myGraphic.DrawCircle(x3 - 3, y3 - 3, 7);
        //            myGraphic.DrawCircle(x5 - 3, y5 - 3, 7);
        //            myGraphic.DrawCircle(x7 - 3, y7 - 3, 7);
        //            break;
        //    }

            
            
        //}

        //public override Shape.MyShape Clone(Diagram myDiagram)
        //{
        //    throw new NotImplementedException();
        //}

        //public override double GetCenterX()
        //{
        //    throw new NotImplementedException();
        //}

        //public override double GetCenterY()
        //{
        //    throw new NotImplementedException();
        //}

        //public override double GetTop()
        //{
        //    return core.GetTop();
        //}

        //public override double GetLeft()
        //{
        //    return core.GetLeft();
        //}

        //public override double GetWidth()
        //{
        //    return core.GetWidth();
        //}

        //public override double GetHeight()
        //{
        //    return core.GetHeight();
        //}

        //public override string GetDescription()
        //{
        //    return "Border";
        //}

        string EffectShape.ToString()
        {
            return "border";
        }
    }
}
