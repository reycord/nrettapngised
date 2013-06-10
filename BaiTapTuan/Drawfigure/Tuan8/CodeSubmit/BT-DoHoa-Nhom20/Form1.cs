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

namespace BT_DoHoa_Nhom20
{
    public partial class FigureDraw : Form
    {
        GraphicLibExt glip;
        PaintEventArgs pe;
      
        double beginX = 0;
        double beginY = 0;
        double endX = 0;
        double endY = 0;

        List<MyShape> myShape;
        int typeofShape = 0;// 0 : line; 1 : Rectangle; 2 : eclipse

        public FigureDraw()
        {
            InitializeComponent();            
            glip = new GdiPlusExt(pnMainPaint.CreateGraphics()); //khởi tạo là gdi
            myShape = new List<MyShape>();
            setEnable(1);
        }

        private void initCairo()
        {
            pe = new PaintEventArgs(pnMainPaint.CreateGraphics(), this.DisplayRectangle);
            glip = new CairoExt(pe.Graphics.GetHdc()); 
        }

        #region Chọn Các Loại hình để vẽ
        private void btnLine_Click(object sender, EventArgs e)
        {
            typeofShape = 0;
        }

        private void btnEclipse_Click(object sender, EventArgs e)
        {
            typeofShape = 2;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            typeofShape = 1;
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
            switch (typeofShape)
            {
                case 0:
                    Temp = new LineEx(beginX, beginY, endX, endY);
                    break;
                case 1:
                    Temp = new RectangleEx(beginX, beginY, endX, endY);
                    break;
                case 2:
                    Temp = new EclipseEx(beginX, beginY, endX, endY);
                    break;
                default: break;
            }

            if (Temp != null)
            {
                Temp.MyGraphic = glip;
                myShape.Add(Temp);
            }
        }

        private void pnMainDraw_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (MyShape shap in myShape)
            {
                shap.Draw();
            }
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
            setEnable(1);
            setCheckDiagramMenu(1);
        }

        private void flowChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setEnable(2);
            setCheckDiagramMenu(2);
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setEnable(2);
            setCheckDiagramMenu(3);
        }

        private void activityDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setEnable(2);
            setCheckDiagramMenu(4);
        }
        private void setCheckDiagramMenu(int CASE)
        {
            freeStyleToolStripMenuItem.Checked = false;
            flowChartToolStripMenuItem.Checked = false;
            dataToolStripMenuItem.Checked = false;
            activityDiagramToolStripMenuItem.Checked = false;
            switch (CASE)
            { 
                case 1:
                    freeStyleToolStripMenuItem.Checked = true;
                    break;
                case 2:
                    flowChartToolStripMenuItem.Checked = true;
                    break;
                case 3:
                    dataToolStripMenuItem.Checked = true;
                    break;
                case 4:
                    activityDiagramToolStripMenuItem.Checked = true;
                    break;
            }
        }
        #endregion

        #region Xử lý effects
        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (enableToolStripMenuItem.Checked == true)
            {
                setEnable(1);
                enableToolStripMenuItem.Checked = false;
            }
            else
            {
                enableToolStripMenuItem.Checked = true; ;
                setEnable(3);
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
                case 1:
                    pnNomal.Enabled = true;
                    break;
                case 2:
                    pnDiagram.Enabled = true;
                    pnNomal.Enabled = true;
                    break;
                case 3: pnEffects.Enabled = true;
                    break;
            }
        }
        #endregion
    }
}
