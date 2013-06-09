using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BT_DoHoa_Nhom20.LibExtend;

namespace BT_DoHoa_Nhom20
{
    public partial class FigureDraw : Form
    {
        GraphicLibExt glip;
        PaintEventArgs pe;
        bool isDraw = false;

        double beginX = 0;
        double beginY = 0;
        double endX = 0;
        double endY = 0;

        public FigureDraw()
        {
            InitializeComponent();
            glip = new GdiPlusExt(pnMainDraw.CreateGraphics());
            //initCairo();
        }

        private void initCairo()
        {
            pe = new PaintEventArgs(pnMainDraw.CreateGraphics(), this.DisplayRectangle);
            glip = new CairoExt(pe.Graphics.GetHdc()); 
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            isDraw = true;
            PaintEventArgs paintEventArgs = new PaintEventArgs(CreateGraphics(), this.DisplayRectangle);
            OnPaint(paintEventArgs);
        }

        private void btnEclipse_Click(object sender, EventArgs e)
        {
            glip.DrawEclipse(30, 50, 65, 86);
            this.Invalidate();
            this.Update();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            glip.DrawRectangle(80, 80, 65, 86);
        }

        private void pnMainDraw_Paint(object sender, PaintEventArgs e)
        {
         
        }

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

        private void pnMainDraw_MouseDown(object sender, MouseEventArgs e)
        {
            beginX = e.X;
            beginY = e.Y;
        }

        private void pnMainDraw_MouseUp(object sender, MouseEventArgs e)
        {
            endX = e.X;
            endY = e.Y;
            glip.DrawLine(beginX, beginY, endX, endY);            
        }

        private void pnMainDraw_MouseMove(object sender, MouseEventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (isDraw)
            {
                glip.DrawLine(20, 20, 100, 100);
            }
        }
    }
}
