using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BT_DoHoa_Nhom20.Shape;

namespace BT_DoHoa_Nhom20
{
    public class ShadowEffectShape : EffectShape
    {
        public void ApplyEffect(MyShape shape, string shapeType, GraphicLibExt myGraphic)
        {
            double x1, x2, y1, y2, w, h;
            switch (shapeType)
            {
                case "Line":
                    //Vẽ đường thẳng song song với đường thẳng gốc
                    LineEx temp = (LineEx)shape;
                    x1 = temp.GetLeft();
                    x2 = temp.GetRight();
                    y1 = temp.GetTop();
                    y2 = temp.GetBottom();
                    myGraphic.SetPenColor(185, 185, 185);
                    myGraphic.SetPenWidth(3);
                    myGraphic.DrawLine(x1+5, y1+5, x2+5, y2+5);
                    //if(myGraphic.GetDescription().Equals("gdi"))
                    break;
                case "rect":
                    //Vẽ hình chữ nhật cùng kích thức nhưng lệch chéo xuống
                    //((RectangleEx)shape)
                    x1 = ((RectangleEx)shape).GetLeft();
                    x2 = ((RectangleEx)shape).GetRight();
                    y1 = ((RectangleEx)shape).GetTop();
                    y2 = ((RectangleEx)shape).GetBottom();
                    w = ((RectangleEx)shape).GetWidth();
                    h = ((RectangleEx)shape).GetHeight();
                    myGraphic.SetPenColor(185, 185, 185);
                    myGraphic.SetPenWidth(2);
                    //Xét hướng của hcn để vẽ highlight cho chính xác
                    if (x1 < x2)    //Vẽ từ trái qua phải
                    {
                        if (y1 < y2)
                        {
                            myGraphic.DrawRectangle(x1 + 5, y1 + 5, w, h);
                        }
                        else
                        {
                            myGraphic.DrawRectangle(x1 + 5, y2 + 5, w, h);
                        }
                    }
                    else
                    {
                        if (y1 < y2)
                        {
                            myGraphic.DrawRectangle(x2 + 5, y1 + 5, w, h);
                        }
                        else
                        {
                            myGraphic.DrawRectangle(x2 + 5, y2 + 5, w, h);
                        }
                    }
                    break;
                case "eclipse":
                    //((EclipseEx)shape)
                    x1 = ((EclipseEx)shape).GetLeft();
                    y1 = ((EclipseEx)shape).GetTop();
                    x2 = ((EclipseEx)shape).GetWidth();
                    y2 = ((EclipseEx)shape).GetHeight();
                    myGraphic.SetPenColor(185, 185, 185);
                    myGraphic.SetPenWidth(2);
                    myGraphic.DrawEclipse(x1 + 5, y1 + 5, x2 + 5, y2 + 5);
                    break;
            }
        }
        public ShadowEffectShape()
        {
            
        }

        //public override void Draw(GraphicLibExt myGraphic)
        //{
        //    /* 
        //     * Vẽ áo xong mới vẽ lõi
        //     * Áo có độ lớn và màu khác lõi để lõi nằm chồng lên áo tạo cảm giác highlight
        //     */
        //    double x1, x2, y1, y2;
        //    switch (core.GetDescription())
        //    {
        //        case "Line":
        //            myGraphic.setPenColor(185, 185, 185);
        //            x1 = core.GetLeft();
        //            y1 = core.GetTop();
        //            x2 = x1 + core.GetWidth();
        //            y2 = y1 + core.GetHeight();
        //            myGraphic.DrawLine(x1, y1 + 2, x2, y2 + 2);
        //            myGraphic.setPenColor(0, 0, 0);
        //            myGraphic.setPenWidth(1.5f);
        //            core.Draw(myGraphic);
        //            break;
        //        case "Eclipse":
        //            myGraphic.setBrushColor(185, 185, 185);
        //            x1 = core.GetLeft();
        //            y1 = core.GetTop();
        //            x2 = core.GetWidth();
        //            y2 = core.GetHeight();
        //            myGraphic.FillEclipse(x1 + 10, y1 + 10, x2 + 10, y2 + 10);
        //            myGraphic.setBrushColor(0, 0, 0);
        //            ((EclipseEx)core).Fill(myGraphic);
        //            break;
        //        case "Rectangle":
        //            myGraphic.setBrushColor(185, 185, 185);
        //            x1 = core.GetLeft();
        //            y1 = core.GetTop();
        //            x2 = core.GetWidth();
        //            y2 = core.GetHeight();
        //            myGraphic.FillRectangle(x1 + 10, y1 + 10, x2 + 10, y2 + 10);
        //            myGraphic.setBrushColor(0, 0, 0);
        //            ((RectangleEx)core).Fill(myGraphic);
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
        //    return "Shadow";
        //}

        string EffectShape.ToString()
        {
            return "shadow";
        }
    }
}
