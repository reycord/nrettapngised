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

        public FigureDraw()
        {
            InitializeComponent();
            //glip = new GdiPlusExt(pnMainDraw.CreateGraphics());
            //glip = new CairoExt(pnMainDraw.CreateGraphics().GetHdc());
            //initCairo();
        }

        private void initCairo()
        {
            pe = new PaintEventArgs(pnMainDraw.CreateGraphics(), new Rectangle(10, 10, 10, 10));
            glip = new CairoExt(pe.Graphics.GetHdc());
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            initCairo();
            glip.DrawLine(20, 20, 100, 100);
        }

        private void btnEclipse_Click(object sender, EventArgs e)
        {
            glip.DrawEclipse(30, 50, 65, 86);
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            glip.DrawRectangle(30, 50, 65, 86);
        }

        private void pnMainDraw_Paint(object sender, PaintEventArgs e)
        {
            //glip = new CairoExt(e.Graphics.GetHdc());
        }
    }
}
