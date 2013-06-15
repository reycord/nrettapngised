using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BT_DoHoa_Nhom20.LibExtend;
using BT_DoHoa_Nhom20.Shape;
using System.Drawing.Imaging;

namespace BT_DoHoa_Nhom20
{
    public partial class FigureDraw : Form
    {
        #region constant
        public const int DIFREESTYPE = 1;
        public const int DIFLOWCHART = 2;
        public const int DIDATAFLOW = 3;
        public const int DIACTIVITY = 4;

        public const int PNNORMAL = 1;
        public const int PNDIAGRAM = 2;
        public const int PNEFFECTS = 3;
        public const int MIEFFECTSHAPE = 4;

        public const int ShpLine      = 0;
        public const int ShpRectangle = 1;
        public const int ShpEclipse   = 2;

        public const int ShpStart = 3;
        public const int ShpEnd =9 ;
        public const int ShpCondition = 8;
        public const int ShpProcess = 5;
        public const int ShpTransition = 7;
        public const int ShpInput = 4;
        public const int ShpOutput = 6;

        public const int LIBCAIRO = 2;
        public const int LIBGDI = 1;
        public const int NODRAW = -1;

        #endregion

        private int currentPanel = PNNORMAL;
        private int currentShape = ShpLine;
        private int currentLib = LIBGDI;

        GraphicLibExt glip;
        PaintEventArgs pe;
        Diagram diagram;

        double beginX = 0;
        double beginY = 0;
        double endX = 0;
        double endY = 0;

        List<MyShape> myShape;
        bool isShadow;
        bool isHighlight;
        bool isBorder = false;

        public FigureDraw()
        {
            InitializeComponent();            
            glip = new GdiPlusExt(pnMainPaint.CreateGraphics()); //khởi tạo là gdi
            myShape = new List<MyShape>();
            setEnable(PNNORMAL);
            setEnable(MIEFFECTSHAPE);
        }


        #region Chọn Các Loại hình để vẽ
        private void btnLine_Click(object sender, EventArgs e)
        {
            currentShape = 0;
        }

        private void btnEclipse_Click(object sender, EventArgs e)
        {
            currentShape = 2;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentShape = 1;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            currentShape = 3;
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            currentShape = 4;
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            currentShape = 5;
        }
        private void btnOutput_Click(object sender, EventArgs e)
        {
            currentShape = 6;
        }
        private void btnTransition_Click(object sender, EventArgs e)
        {
            currentShape = 7;
        }
        private void btnCondition_Click(object sender, EventArgs e)
        {
            currentShape = 8;
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            currentShape = 9;
        }
        #endregion

        #region xử lý chuột
        private void pnMainDraw_MouseDown(object sender, MouseEventArgs e)
        {
            beginX = e.X;
            beginY = e.Y;
        }

        private void pnMainDraw_MouseUp(object sender, MouseEventArgs e)
        {
            endX = e.X;
            endY = e.Y;

            MyShape Temp = null;
            StartShape s1 = null;
            OutputShape s2 = null;
            ProcessShape s3 = null;
            InputShape s4 = null;
            TransitionShape s5 = null;
            EndShape s6 = null;
            ConditionShape s7 = null;
            switch (currentShape)
            {
                case NODRAW:
                    foreach (MyShape shape in myShape)
                    {
                        if (isSelected(shape))
                        {
                            shape.attachEffect(new BorderEffectShape());
                            //Kiểm tra và add effect 
                            if (isShadow)
                            {
                                shape.attachEffect(new ShadowEffectShape());
                            }
                            else
                            {
                                shape.detachEffect(new ShadowEffectShape());
                            }
                            if (isHighlight)
                            {
                                shape.attachEffect(new HighlightEffectShape());
                            }
                            else
                            {
                                shape.detachEffect(new HighlightEffectShape());
                            }
                        }
                    }
                    break;
                case ShpLine:
                    Temp = new LineEx(beginX, beginY, endX, endY);
                    if (Temp != null)
                        myShape.Add(Temp);             
                    break;
                case ShpRectangle:
                    Temp = new RectangleEx(beginX, beginY, endX, endY);
                    if (Temp != null)
                        myShape.Add(Temp);
                    break;
                case ShpEclipse:
                    Temp = new EclipseEx(beginX, beginY, endX, endY);
                    if (Temp != null)
                        myShape.Add(Temp);
                    break;
                case ShpStart:
                    s1 = diagram.CreateStart(beginX, beginY, endX, endY);
                    if (s1 != null)
                        //ListStartShape.Add(s1);
                        myShape.Add(s1);
                    break;
                case ShpTransition:
                    s5 = diagram.CreateTransition(beginX, beginY, endX, endY);
                    if (s5 != null)
                        //ListTransitionShape.Add(s5);
                        myShape.Add(s5);
                    break;
                case ShpProcess:
                    s3 = diagram.CreateProcess(beginX, beginY, Math.Abs(beginX - endX), Math.Abs(beginY - endY));
                    if (s3 != null)
                        //ListProcessShape.Add(s3);
                        myShape.Add(s3);
                    break;
                case ShpOutput:
                    s2 = diagram.CreateOutput(beginX, beginY, Math.Abs(beginX - endX), Math.Abs(beginY - endY));
                    if (s2 != null)
                        //ListOutputShape.Add(s2);
                        myShape.Add(s2);
                    break;
                case ShpInput:
                    s4 = diagram.CreateInput(beginX, beginY, Math.Abs(beginX - endX), Math.Abs(beginY - endY));
                    if (s4 != null)
                        //ListInputShape.Add(s4);
                        myShape.Add(s4);
                    break;
                case ShpCondition:
                    s7 = diagram.CreateCondition(beginX, beginY, Math.Abs(beginX - endX), Math.Abs(beginY - endY));
                    if (s7 != null)
                        //ListConditionShape.Add(s7);
                        myShape.Add(s7);
                    break;
                case ShpEnd:
                    s6 = diagram.CreateEnd(beginX, beginY, endX, endY);
                    if (s6 != null)
                        //ListEndShape.Add(s6);
                        myShape.Add(s6);
                    break;
                default: break;
            }
            
        }
        private void Convert(Diagram diagram)
        {
            for (int i = 0; i < myShape.Count;i++ )
            {
                MyShape temp = myShape[i].Clone(diagram);
                if (temp != null)
                    myShape[i] = temp;
            }
            pnMainPaint.Refresh();
        }
        private void pnMainDraw_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (MyShape shape in myShape)
            {
                //Vẽ hình (bao gồm vẽ effect)
                shape.Draw(glip);
            }
            //foreach (StartShape shap in ListStartShape)
            //{
            //    shap.Draw(glip);
            //}
        }
        #endregion

        #region Xử lý Lib Support
        private void cairoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check trên menu là cairo
            cairoToolStripMenuItem.Checked = true;
            gDIPlusToolStripMenuItem.Checked = false;
            currentLib = LIBCAIRO;
            initCairo();
        }

        private void gDIPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check trên menu là gdi
            cairoToolStripMenuItem.Checked = false;
            gDIPlusToolStripMenuItem.Checked = true;
            glip = new GdiPlusExt(pnMainPaint.CreateGraphics());
            currentLib = LIBGDI;            
        }
        #endregion       

        #region Xử lý  Diagram
        private void freeStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            setEnable(PNNORMAL);
            setEnable(MIEFFECTSHAPE);
            setCheckDiagramMenu(DIFREESTYPE);
        }

        private void flowChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setEnable(PNDIAGRAM);
            setCheckDiagramMenu(DIFLOWCHART);
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setEnable(PNDIAGRAM);
            setCheckDiagramMenu(DIDATAFLOW);
        }

        private void activityDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setEnable(PNDIAGRAM);
            setCheckDiagramMenu(DIACTIVITY);
        }
        private void setCheckDiagramMenu(int CASE)
        {
            freeStyleToolStripMenuItem.Checked = false;
            flowChartToolStripMenuItem.Checked = false;
            dataToolStripMenuItem.Checked = false;
            activityDiagramToolStripMenuItem.Checked = false;
            switch (CASE)
            {
                case DIFREESTYPE:
                    freeStyleToolStripMenuItem.Checked = true;
                    break;
                case DIFLOWCHART:
                    flowChartToolStripMenuItem.Checked = true;
                    diagram = new FlowChart();
                    Convert(diagram);
                    break;
                case DIDATAFLOW:
                    dataToolStripMenuItem.Checked = true;
                    diagram = new DataFlowDiagram();
                    Convert(diagram);
                    break;
                case DIACTIVITY:
                    activityDiagramToolStripMenuItem.Checked = true;
                    diagram =new ActivityDiagram();
                    Convert(diagram);
                    break;
            }
        }

        
        #endregion

        #region Xử lý effects
        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enableToolStripMenuItem.Checked == true)
            {
                setEnable(currentPanel);
                enableToolStripMenuItem.Checked = false;
                currentShape = 1;
            }
            else
            {                
                setEnable(PNEFFECTS);
                enableToolStripMenuItem.Checked = true;
                currentShape = -1;
            }
        }

        //Chọn được 1 hình
        public bool isSelected(MyShape shape)
        {
            double mouseX = pnMainPaint.PointToClient(Cursor.Position).X;
            double mouseY = pnMainPaint.PointToClient(Cursor.Position).Y;
            double x1, y1, x2, y2, w, h;
            switch (shape.ToString())
            {
                case "line":
                    LineEx temp = (LineEx)shape;
                    x1 = temp.GetLeft();
                    x2 = temp.GetRight();
                    y1 = temp.GetTop();
                    y2 = temp.GetBottom();
                    w = temp.GetWidth();
                    h = temp.GetHeight();
                    return WithinShapeBound(mouseX, mouseY, x1, y1, x2, y2);
                case "rect":
                    RectangleEx tempRect = (RectangleEx)shape;
                    x1 = tempRect.GetLeft();
                    x2 = tempRect.GetRight();
                    y1 = tempRect.GetTop();
                    y2 = tempRect.GetBottom();
                    w = tempRect.GetWidth();
                    h = tempRect.GetHeight();
                    return WithinShapeBound(mouseX, mouseY, x1, y1, x2, y2);
                case "eclipse":
                    return (mouseX >= beginX && mouseX <= endX && mouseY <= endY && mouseY >= beginY);
                default:
                    return false;
            }
        }

        private static bool WithinShapeBound(double mouseX, double mouseY, double x1, double y1, double x2, double y2)
        {
            if (x1 < x2)
            {
                // Hướng từ top-left xuống bottom-right
                if (y1 > y2)
                {
                    return (x1 <= mouseX && mouseX <= x2 && y1 >= mouseY && mouseY >= y2);
                }
                // Hướng từ bottom-left lên top-right
                else
                {
                    return (x1 <= mouseX && mouseX <= x2 && y1 <= mouseY && mouseY <= y2);
                }
            }
            else
            {
                // Hướng từ top-right xuống bottom-left                    
                if (y1 > y2)
                {
                    return (x2 <= mouseX && mouseX <= x1 && y1 >= mouseY && mouseY >= y2);
                }
                // Hướng từ bottom-right lên top-left
                else
                {
                    return (x1 >= mouseX && mouseX >= x2 && y1 <= mouseY && mouseY <= y2);
                }
            }
        }
        #endregion

        #region Sự kiện Lưu - Mở File
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogsave dlgsave = new dialogsave();
            dlgsave.ShowDialog();
            String name = dlgsave.NameOfFile;
            String type = dlgsave.TypeOfFile;
            if (!String.IsNullOrEmpty(name))
            {
                if (type.Equals(".png") || type.Equals(".jpg"))
                {
                    Image img;
                    img = new Bitmap(1024, 768);
                    Graphics g = Graphics.FromImage(img);
                    GraphicLibExt temp;
                    if (currentLib == LIBGDI)
                        temp = new GdiPlusExt(g);
                    else 
                        temp = new CairoExt(g.GetHdc());
                    
                    foreach (MyShape shap in myShape)
                    {
                        shap.Draw(temp);
                    }
                    if (type.Equals(".png"))
                        img.Save(name + type, ImageFormat.Png);
                    if (type.Equals(".jpg"))
                        img.Save(name + type, ImageFormat.Jpeg);

                }
                else
                {
                    MessageBox.Show("Chưa Hỗ Trợ Chức Năng Lưu SVG");
                }
            }
        }
        #endregion

        #region Xử lý chung
        //xử lý các trường hợp cho phép bật tắt các panel..và effect-->selectshape
        private void setEnable(int CASE)
        {
            
            pnDiagram.Enabled = false;
            pnEffects.Enabled = false;
            pnNomal.Enabled = false;
            enableToolStripMenuItem.Enabled = false;
            enableToolStripMenuItem.Checked = false;

            switch (CASE)
            {
                case PNNORMAL:
                    pnNomal.Enabled = true;
                    currentPanel = CASE;
                    break;
                case PNDIAGRAM:
                    pnDiagram.Enabled = true;
                    pnNomal.Enabled = true;
                    currentPanel = CASE;
                    break;
                case PNEFFECTS:
                    pnEffects.Enabled = true;
                    enableToolStripMenuItem.Enabled = true;                    
                    break;
                case MIEFFECTSHAPE:
                    enableToolStripMenuItem.Enabled = true;                    
                    pnNomal.Enabled = true;
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myShape.Clear();
            pnMainPaint.Refresh();
        }

        private void initCairo()
        {
            pe = new PaintEventArgs(pnMainPaint.CreateGraphics(), this.DisplayRectangle);
            glip = new CairoExt(pe.Graphics.GetHdc());
        }
        #endregion

        private void cbShadow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShadow.Checked)
                isShadow = true;
            else
                isShadow = false;
        }

        private void cbHighlight_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHighlight.Checked)
                isHighlight = true;
            else
                isHighlight = false;
        }

    }
}
