namespace BT_DoHoa_Nhom20
{
    partial class FigureDraw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FigureDraw));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cairoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gDIPlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMainDraw = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEclipse = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.libSupportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // libSupportToolStripMenuItem
            // 
            this.libSupportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cairoToolStripMenuItem,
            this.gDIPlusToolStripMenuItem});
            this.libSupportToolStripMenuItem.Name = "libSupportToolStripMenuItem";
            this.libSupportToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.libSupportToolStripMenuItem.Text = "Lib support";
            // 
            // cairoToolStripMenuItem
            // 
            this.cairoToolStripMenuItem.Name = "cairoToolStripMenuItem";
            this.cairoToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.cairoToolStripMenuItem.Text = "Cairo";
            this.cairoToolStripMenuItem.Click += new System.EventHandler(this.cairoToolStripMenuItem_Click);
            // 
            // gDIPlusToolStripMenuItem
            // 
            this.gDIPlusToolStripMenuItem.Checked = true;
            this.gDIPlusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gDIPlusToolStripMenuItem.Name = "gDIPlusToolStripMenuItem";
            this.gDIPlusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gDIPlusToolStripMenuItem.Text = "GDI Plus";
            this.gDIPlusToolStripMenuItem.Click += new System.EventHandler(this.gDIPlusToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pnMainDraw);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 408);
            this.panel1.TabIndex = 1;
            // 
            // pnMainDraw
            // 
            this.pnMainDraw.BackColor = System.Drawing.Color.Transparent;
            this.pnMainDraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMainDraw.Location = new System.Drawing.Point(91, 4);
            this.pnMainDraw.Name = "pnMainDraw";
            this.pnMainDraw.Size = new System.Drawing.Size(638, 401);
            this.pnMainDraw.TabIndex = 1;
            this.pnMainDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMainDraw_Paint);
            this.pnMainDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnMainDraw_MouseDown);
            this.pnMainDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMainDraw_MouseMove);
            this.pnMainDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnMainDraw_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnRectangle);
            this.panel2.Controls.Add(this.btnEclipse);
            this.panel2.Controls.Add(this.btnLine);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 402);
            this.panel2.TabIndex = 0;
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(7, 121);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(64, 50);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEclipse
            // 
            this.btnEclipse.Location = new System.Drawing.Point(7, 65);
            this.btnEclipse.Name = "btnEclipse";
            this.btnEclipse.Size = new System.Drawing.Size(64, 49);
            this.btnEclipse.TabIndex = 1;
            this.btnEclipse.Text = "Eclipse";
            this.btnEclipse.UseVisualStyleBackColor = true;
            this.btnEclipse.Click += new System.EventHandler(this.btnEclipse_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(7, 13);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(65, 45);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // FigureDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FigureDraw";
            this.Text = "Draw Figure";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnMainDraw;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEclipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.ToolStripMenuItem libSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cairoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gDIPlusToolStripMenuItem;

    }
}

