using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BT_DoHoa_Nhom20.Shape;

namespace BT_DoHoa_Nhom20
{
    public class HighlightEffectShape : EffectShape
    {
        public HighlightEffectShape()
        {
        }

        public void ApplyEffect(MyShape shape, string shapeType, GraphicLibExt myGraphic)
        {
            double x1, x2, y1, y2, w, h;
            switch (shapeType)
            {
                case "Line":
                    //Vẽ 2 đường thẳng 1 trên 1 dưới tạo hiệu ứng highlight
                    //((LineEx)shape)
                    x1 = ((LineEx)shape).GetLeft();
                    x2 = ((LineEx)shape).GetRight();
                    y1 = ((LineEx)shape).GetTop();
                    y2 = ((LineEx)shape).GetBottom();
                    myGraphic.SetPenColor(185, 185, 185);
                    myGraphic.SetPenWidth(2);
                    myGraphic.DrawLine(x1, y1 + 3, x2, y2 + 3);
                    myGraphic.DrawLine(x1, y1 - 3, x2, y2 - 3);
                    //if(myGraphic.GetDescription().Equals("gdi"))
                    break;
                case "rect":
                    //Vẽ hình chữ nhật bao ở ngoài
                    //((RectangleEx)shape)
                    x1 = ((RectangleEx)shape).GetLeft();
                    x2 = ((RectangleEx)shape).GetRight();
                    y1 = ((RectangleEx)shape).GetTop();
                    y2 = ((RectangleEx)shape).GetBottom();
                    w = ((RectangleEx)shape).GetWidth();
                    h = ((RectangleEx)shape).GetHeight();
                    myGraphic.SetBrushColor(185, 185, 185);
                    //myGraphic.SetPenWidth(2);
                    //Xét hướng của hcn để vẽ highlight cho chính xác
                    if (x1 < x2)    //Vẽ từ trái qua phải
                    {
                        if (y1 < y2)
                        {
                            //myGraphic.DrawRectangle(x1 - 3, y1 - 3, w + 6, h + 6);
                            myGraphic.FillRectangle(x1 - 3, y1 - 3, w + 6, h + 6);
                        }
                        else
                        {
                            //myGraphic.DrawRectangle(x1 - 3, y2 - 3, w + 6, h + 6);
                            myGraphic.FillRectangle(x1 - 3, y2 - 3, w + 6, h + 6);
                        }
                    }
                    else
                    {
                        if (y1 < y2)
                        {
                            //myGraphic.DrawRectangle(x2 - 3, y1 - 3, w + 6, h + 6);
                            myGraphic.FillRectangle(x2 - 3, y1 - 3, w + 6, h + 6);
                        }
                        else
                        {
                            //myGraphic.DrawRectangle(x2 - 3, y2 - 3, w + 6, h + 6);
                            myGraphic.FillRectangle(x2 - 3, y1 - 3, w + 6, h + 6);
                        }
                    }
                    break;
                case "eclipse":
                    //myGraphic.SetPenColor(185, 185, 185);
                    //myGraphic.SetPenWidth(2);
                    myGraphic.SetBrushColor(185, 185, 185);
                    x1 = ((EclipseEx)shape).GetLeft();
                    x2 = ((EclipseEx)shape).GetWidth();
                    y1 = ((EclipseEx)shape).GetTop();
                    y2 = ((EclipseEx)shape).GetHeight();
                    myGraphic.FillEclipse(x1 - 3, y1 - 3, x2 + 3, y2 + 3);
                    break;
            }
        }
        //public HighlightEffectShape(Shape.MyShape shape)
        //{
        //    // TODO: Complete member initialization
        //    core = shape;
        //}
        //public override void Draw(GraphicLibExt myGraphic)
        //{
        //    double x1, x2, y1, y2;
        //    switch (core.GetDescription())
        //    {
        //        case "Line":
        //            myGraphic.setPenWidth(3.5f);
        //            myGraphic.setPenColor(185, 185, 185);
        //            x1 = core.GetLeft();
        //            y1 = core.GetTop();
        //            x2 = x1 + core.GetWidth();
        //            y2 = y1 + core.GetHeight();
        //            myGraphic.DrawLine(x1, y1, x2, y2);
        //            myGraphic.setPenColor(0, 0, 0);
        //            myGraphic.setPenWidth(1.5f);
        //            core.Draw(myGraphic);
        //            break;
        //        case "Eclipse":
        //            myGraphic.setPenWidth(3.5f);
        //            myGraphic.setPenColor(185, 185, 185);
        //            x1 = core.GetLeft();
        //            y1 = core.GetTop();
        //            x2 = core.GetWidth();
        //            y2 = core.GetHeight();
        //            myGraphic.DrawEclipse(x1 - 3.5, y1 - 3.5, x2 + 3.5, y2 + 3.5);
        //            myGraphic.setPenColor(0, 0, 0);
        //            myGraphic.setPenWidth(1.5f);
        //            core.Draw(myGraphic);
        //            break;
        //        case "Rectangle":
        //            myGraphic.setPenWidth(3.5f);
        //            myGraphic.setPenColor(185, 185, 185);
        //            x1 = core.GetLeft();
        //            y1 = core.GetTop();
        //            x2 = core.GetWidth();
        //            y2 = core.GetHeight();
        //            myGraphic.DrawRectangle(x1 - 3.5f, y1 - 3.5f, x2 + 7, y2 + 7);
        //            myGraphic.setPenColor(0, 0, 0);
        //            myGraphic.setPenWidth(1.5f);
        //            core.Draw(myGraphic);
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
        //    return "Highlight";
        //}


        string EffectShape.ToString()
        {
            return "highlight";
        }
    }
}
