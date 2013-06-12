﻿using System;
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
        #endregion

        private int currentPanel = PNNORMAL;
        private int currentShape = ShpLine;
        GraphicLibExt glip;
        PaintEventArgs pe;
        Diagram diagram;

        double beginX = 0;
        double beginY = 0;
        double endX = 0;
        double endY = 0;

        List<MyShape> myShape;

        public FigureDraw()
        {
            InitializeComponent();            
            glip = new GdiPlusExt(pnMainPaint.CreateGraphics()); //khởi tạo là gdi
            myShape = new List<MyShape>();
            setEnable(PNNORMAL);
        }

        private void initCairo()
        {
            pe = new PaintEventArgs(pnMainPaint.CreateGraphics(), this.DisplayRectangle);
            glip = new CairoExt(pe.Graphics.GetHdc()); 
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
            foreach (MyShape shap in myShape)
            {
                shap.Draw(glip);
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
            initCairo();
        }

        private void gDIPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check trên menu là gdi
            cairoToolStripMenuItem.Checked = false;
            gDIPlusToolStripMenuItem.Checked = true;
            glip = new GdiPlusExt(pnMainPaint.CreateGraphics());
        }
        #endregion       

        #region Xử lý  Diagram
        private void freeStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setEnable(PNNORMAL);
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
            }
            else
            {
                enableToolStripMenuItem.Checked = true;
                setEnable(PNEFFECTS);
            }
        }
        #endregion

        #region Xử lý chung
        //xử lý các trường hợp cho phép bật tắt các panel
        private void setEnable(int CASE)
        {
            
            pnDiagram.Enabled = false;
            pnEffects.Enabled = false;
            pnNomal.Enabled = false;

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
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myShape.Clear();
            pnMainPaint.Refresh();
        }
        #endregion

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogsave dlgsave = new dialogsave();
            dlgsave.ShowDialog();
           
            String name = dlgsave.NameOfFile;
            String type = dlgsave.TypeOfFile;
            if (!String.IsNullOrEmpty(name))
            {
                Image img;
                if (type.Equals(".png"))
                {
                    img = new Bitmap(1024, 768);
                    Graphics g = Graphics.FromImage(img);
                    GraphicLibExt temp = new GdiPlusExt(g);
                    foreach (MyShape shap in myShape)
                    {
                        shap.Draw(temp);
                    }
                    img.Save(name + type,ImageFormat.Png);
                }
                else if (type.Equals(".jpg"))
                {
                    img = new Bitmap(1024, 768);
                    Graphics g = Graphics.FromImage(img);
                    GraphicLibExt temp = new GdiPlusExt(g);
                    foreach (MyShape shap in myShape)
                    {
                        shap.Draw(temp);
                    }
                    img.Save(name + type,ImageFormat.Jpeg);
                }
                else {
                    MessageBox.Show("Chưa Hỗ Trợ Chức Năng Lưu SVG");
                }
            }
        }  
    }
}
