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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cairoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gDIPlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeStyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnBackground = new System.Windows.Forms.Panel();
            this.pnMainPaint = new System.Windows.Forms.Panel();
            this.pnShape = new System.Windows.Forms.Panel();
            this.pnNomal = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEclipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.pnDiagram = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnCondition = new System.Windows.Forms.Button();
            this.btnTransition = new System.Windows.Forms.Button();
            this.pnEffects = new System.Windows.Forms.Panel();
            this.cbHighlight = new System.Windows.Forms.CheckBox();
            this.cbShadow = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnBackground.SuspendLayout();
            this.pnShape.SuspendLayout();
            this.pnNomal.SuspendLayout();
            this.pnDiagram.SuspendLayout();
            this.pnEffects.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.libSupportToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.eToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
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
            this.gDIPlusToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.gDIPlusToolStripMenuItem.Text = "GDI Plus";
            this.gDIPlusToolStripMenuItem.Click += new System.EventHandler(this.gDIPlusToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeStyleToolStripMenuItem,
            this.flowChartToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.activityDiagramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.helpToolStripMenuItem.Text = "Diagram";
            // 
            // freeStyleToolStripMenuItem
            // 
            this.freeStyleToolStripMenuItem.Checked = true;
            this.freeStyleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.freeStyleToolStripMenuItem.Name = "freeStyleToolStripMenuItem";
            this.freeStyleToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.freeStyleToolStripMenuItem.Text = "Free Style";
            this.freeStyleToolStripMenuItem.Click += new System.EventHandler(this.freeStyleToolStripMenuItem_Click);
            // 
            // flowChartToolStripMenuItem
            // 
            this.flowChartToolStripMenuItem.Name = "flowChartToolStripMenuItem";
            this.flowChartToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.flowChartToolStripMenuItem.Text = "Flow Chart";
            this.flowChartToolStripMenuItem.Click += new System.EventHandler(this.flowChartToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dataToolStripMenuItem.Text = "Data Flow Diagram";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // activityDiagramToolStripMenuItem
            // 
            this.activityDiagramToolStripMenuItem.Name = "activityDiagramToolStripMenuItem";
            this.activityDiagramToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.activityDiagramToolStripMenuItem.Text = "Activity Diagram";
            this.activityDiagramToolStripMenuItem.Click += new System.EventHandler(this.activityDiagramToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem});
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.eToolStripMenuItem.Text = "Effects";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.enableToolStripMenuItem.Text = "Select Shape";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // pnBackground
            // 
            this.pnBackground.BackColor = System.Drawing.Color.SteelBlue;
            this.pnBackground.Controls.Add(this.pnMainPaint);
            this.pnBackground.Controls.Add(this.pnShape);
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackground.Location = new System.Drawing.Point(0, 24);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(1052, 521);
            this.pnBackground.TabIndex = 1;
            // 
            // pnMainPaint
            // 
            this.pnMainPaint.BackColor = System.Drawing.Color.Transparent;
            this.pnMainPaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMainPaint.Location = new System.Drawing.Point(92, 4);
            this.pnMainPaint.Name = "pnMainPaint";
            this.pnMainPaint.Size = new System.Drawing.Size(957, 517);
            this.pnMainPaint.TabIndex = 1;
            this.pnMainPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnMainDraw_MouseDown);
            this.pnMainPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMainDraw_MouseMove);
            this.pnMainPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnMainDraw_MouseUp);
            // 
            // pnShape
            // 
            this.pnShape.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnShape.Controls.Add(this.pnNomal);
            this.pnShape.Controls.Add(this.pnDiagram);
            this.pnShape.Controls.Add(this.pnEffects);
            this.pnShape.Controls.Add(this.btnClear);
            this.pnShape.Location = new System.Drawing.Point(3, 3);
            this.pnShape.Name = "pnShape";
            this.pnShape.Size = new System.Drawing.Size(90, 515);
            this.pnShape.TabIndex = 0;
            // 
            // pnNomal
            // 
            this.pnNomal.Controls.Add(this.btnLine);
            this.pnNomal.Controls.Add(this.btnEclipse);
            this.pnNomal.Controls.Add(this.btnRectangle);
            this.pnNomal.Location = new System.Drawing.Point(9, 3);
            this.pnNomal.Name = "pnNomal";
            this.pnNomal.Size = new System.Drawing.Size(71, 96);
            this.pnNomal.TabIndex = 15;
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(3, 3);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(65, 27);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEclipse
            // 
            this.btnEclipse.Location = new System.Drawing.Point(3, 36);
            this.btnEclipse.Name = "btnEclipse";
            this.btnEclipse.Size = new System.Drawing.Size(64, 26);
            this.btnEclipse.TabIndex = 1;
            this.btnEclipse.Text = "Eclipse";
            this.btnEclipse.UseVisualStyleBackColor = true;
            this.btnEclipse.Click += new System.EventHandler(this.btnEclipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(3, 68);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(64, 25);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // pnDiagram
            // 
            this.pnDiagram.Controls.Add(this.btnStart);
            this.pnDiagram.Controls.Add(this.btnInput);
            this.pnDiagram.Controls.Add(this.btnProcess);
            this.pnDiagram.Controls.Add(this.btnEnd);
            this.pnDiagram.Controls.Add(this.btnOutput);
            this.pnDiagram.Controls.Add(this.btnCondition);
            this.pnDiagram.Controls.Add(this.btnTransition);
            this.pnDiagram.Location = new System.Drawing.Point(9, 102);
            this.pnDiagram.Name = "pnDiagram";
            this.pnDiagram.Size = new System.Drawing.Size(71, 219);
            this.pnDiagram.TabIndex = 14;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(64, 26);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(3, 38);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(64, 26);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(3, 71);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(64, 24);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(3, 191);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(64, 23);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(3, 101);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(64, 24);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "Output";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnCondition
            // 
            this.btnCondition.Location = new System.Drawing.Point(3, 161);
            this.btnCondition.Name = "btnCondition";
            this.btnCondition.Size = new System.Drawing.Size(64, 24);
            this.btnCondition.TabIndex = 8;
            this.btnCondition.Text = "Condition";
            this.btnCondition.UseVisualStyleBackColor = true;
            this.btnCondition.Click += new System.EventHandler(this.btnCondition_Click);
            // 
            // btnTransition
            // 
            this.btnTransition.Location = new System.Drawing.Point(3, 131);
            this.btnTransition.Name = "btnTransition";
            this.btnTransition.Size = new System.Drawing.Size(64, 24);
            this.btnTransition.TabIndex = 7;
            this.btnTransition.Text = "Transition";
            this.btnTransition.UseVisualStyleBackColor = true;
            this.btnTransition.Click += new System.EventHandler(this.btnTransition_Click);
            // 
            // pnEffects
            // 
            this.pnEffects.Controls.Add(this.cbHighlight);
            this.pnEffects.Controls.Add(this.cbShadow);
            this.pnEffects.Location = new System.Drawing.Point(4, 327);
            this.pnEffects.Name = "pnEffects";
            this.pnEffects.Size = new System.Drawing.Size(76, 121);
            this.pnEffects.TabIndex = 13;
            // 
            // cbHighlight
            // 
            this.cbHighlight.AutoSize = true;
            this.cbHighlight.Location = new System.Drawing.Point(5, 35);
            this.cbHighlight.Name = "cbHighlight";
            this.cbHighlight.Size = new System.Drawing.Size(67, 17);
            this.cbHighlight.TabIndex = 1;
            this.cbHighlight.Text = "Highlight";
            this.cbHighlight.UseVisualStyleBackColor = true;
            this.cbHighlight.CheckedChanged += new System.EventHandler(this.cbHighlight_CheckedChanged);
            // 
            // cbShadow
            // 
            this.cbShadow.AutoSize = true;
            this.cbShadow.Location = new System.Drawing.Point(5, 12);
            this.cbShadow.Name = "cbShadow";
            this.cbShadow.Size = new System.Drawing.Size(65, 17);
            this.cbShadow.TabIndex = 0;
            this.cbShadow.Text = "Shadow";
            this.cbShadow.UseVisualStyleBackColor = true;
            this.cbShadow.CheckedChanged += new System.EventHandler(this.cbShadow_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 52);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FigureDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 545);
            this.Controls.Add(this.pnBackground);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FigureDraw";
            this.Text = "Draw Figure";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnBackground.ResumeLayout(false);
            this.pnShape.ResumeLayout(false);
            this.pnNomal.ResumeLayout(false);
            this.pnDiagram.ResumeLayout(false);
            this.pnEffects.ResumeLayout(false);
            this.pnEffects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.Panel pnShape;
        private System.Windows.Forms.Panel pnMainPaint;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEclipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.ToolStripMenuItem libSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cairoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gDIPlusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityDiagramToolStripMenuItem;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnCondition;
        private System.Windows.Forms.Button btnTransition;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripMenuItem freeStyleToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.Panel pnEffects;
        private System.Windows.Forms.Panel pnDiagram;
        private System.Windows.Forms.Panel pnNomal;
        private System.Windows.Forms.CheckBox cbHighlight;
        private System.Windows.Forms.CheckBox cbShadow;

    }
}

