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

            glip = new GdiPlusExt(pnMainDraw.CreateGraphics()); //khởi tạo là gdi
            myShape = new List<MyShape>();
        }

        private void initCairo()
        {
            pe = new PaintEventArgs(pnMainDraw.CreateGraphics(), this.DisplayRectangle);
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

        #region xử lý menu
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
            glip = new GdiPlusExt(pnMainDraw.CreateGraphics());
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
                    Temp = new LineEx(beginX, endX, beginY, endY);
                    break;
                case 1 :
                    Temp = new RectangleEx(beginX, endX, beginY, endY);
                    break;
                case 2:
                    Temp = new EclipseEx(beginX, endX, beginY, endY);
                    break;
                default: break;
            }

            if(Temp !=null)
                myShape.Add(Temp);
        }

        private void pnMainDraw_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (MyShape shap in myShape)
            {
                shap.Draw();
            }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
          
        }
    }
}
