namespace HW3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pensTabPage = new System.Windows.Forms.TabPage();
            this.brushesTabPage = new System.Windows.Forms.TabPage();
            this.imagePanningTabPage = new System.Windows.Forms.TabPage();
            this.shapesAndTextTabPage = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1047);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1495, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pensTabPage);
            this.tabControl.Controls.Add(this.brushesTabPage);
            this.tabControl.Controls.Add(this.imagePanningTabPage);
            this.tabControl.Controls.Add(this.shapesAndTextTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(115, 18);
            this.tabControl.Location = new System.Drawing.Point(0, 40);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1495, 1007);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // pensTabPage
            // 
            this.pensTabPage.Location = new System.Drawing.Point(8, 26);
            this.pensTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.pensTabPage.Name = "pensTabPage";
            this.pensTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.pensTabPage.Size = new System.Drawing.Size(1479, 973);
            this.pensTabPage.TabIndex = 0;
            this.pensTabPage.Text = "Pens";
            this.pensTabPage.UseVisualStyleBackColor = true;
            this.pensTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.pensTabPage_Paint);
            // 
            // brushesTabPage
            // 
            this.brushesTabPage.Location = new System.Drawing.Point(8, 26);
            this.brushesTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.brushesTabPage.Name = "brushesTabPage";
            this.brushesTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.brushesTabPage.Size = new System.Drawing.Size(1479, 971);
            this.brushesTabPage.TabIndex = 1;
            this.brushesTabPage.Text = "Brushes";
            this.brushesTabPage.UseVisualStyleBackColor = true;
            this.brushesTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.brushesTabPage_Paint);
            // 
            // imagePanningTabPage
            // 
            this.imagePanningTabPage.Location = new System.Drawing.Point(8, 26);
            this.imagePanningTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.imagePanningTabPage.Name = "imagePanningTabPage";
            this.imagePanningTabPage.Size = new System.Drawing.Size(1479, 971);
            this.imagePanningTabPage.TabIndex = 2;
            this.imagePanningTabPage.Text = "Image Panning";
            this.imagePanningTabPage.UseVisualStyleBackColor = true;
            this.imagePanningTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.imagePanningTabPage_Paint);
            // 
            // shapesAndTextTabPage
            // 
            this.shapesAndTextTabPage.Location = new System.Drawing.Point(8, 26);
            this.shapesAndTextTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.shapesAndTextTabPage.Name = "shapesAndTextTabPage";
            this.shapesAndTextTabPage.Size = new System.Drawing.Size(1479, 971);
            this.shapesAndTextTabPage.TabIndex = 3;
            this.shapesAndTextTabPage.Text = "Shapes and Text";
            this.shapesAndTextTabPage.UseVisualStyleBackColor = true;
            this.shapesAndTextTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.shapesAndTextTabPage_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pensToolStripMenuItem,
            this.brushToolStripMenuItem,
            this.shapeToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1495, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pensToolStripMenuItem
            // 
            this.pensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.customToolStripMenuItem,
            this.compoundToolStripMenuItem});
            this.pensToolStripMenuItem.Name = "pensToolStripMenuItem";
            this.pensToolStripMenuItem.Size = new System.Drawing.Size(76, 38);
            this.pensToolStripMenuItem.Text = "Pens";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // compoundToolStripMenuItem
            // 
            this.compoundToolStripMenuItem.Name = "compoundToolStripMenuItem";
            this.compoundToolStripMenuItem.Size = new System.Drawing.Size(235, 38);
            this.compoundToolStripMenuItem.Text = "Compound";
            this.compoundToolStripMenuItem.Click += new System.EventHandler(this.compoundToolStripMenuItem_Click);
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem1,
            this.textureToolStripMenuItem,
            this.hatchToolStripMenuItem,
            this.linearGradientToolStripMenuItem,
            this.pathGradientToolStripMenuItem});
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(87, 38);
            this.brushToolStripMenuItem.Text = "Brush";
            // 
            // solidToolStripMenuItem1
            // 
            this.solidToolStripMenuItem1.Name = "solidToolStripMenuItem1";
            this.solidToolStripMenuItem1.Size = new System.Drawing.Size(277, 38);
            this.solidToolStripMenuItem1.Text = "Solid";
            this.solidToolStripMenuItem1.Click += new System.EventHandler(this.solidToolStripMenuItem1_Click);
            // 
            // textureToolStripMenuItem
            // 
            this.textureToolStripMenuItem.Name = "textureToolStripMenuItem";
            this.textureToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.textureToolStripMenuItem.Text = "Texture";
            this.textureToolStripMenuItem.Click += new System.EventHandler(this.textureToolStripMenuItem_Click);
            // 
            // hatchToolStripMenuItem
            // 
            this.hatchToolStripMenuItem.Name = "hatchToolStripMenuItem";
            this.hatchToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.hatchToolStripMenuItem.Text = "Hatch";
            this.hatchToolStripMenuItem.Click += new System.EventHandler(this.hatchToolStripMenuItem_Click);
            // 
            // linearGradientToolStripMenuItem
            // 
            this.linearGradientToolStripMenuItem.Name = "linearGradientToolStripMenuItem";
            this.linearGradientToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.linearGradientToolStripMenuItem.Text = "Linear Gradient";
            this.linearGradientToolStripMenuItem.Click += new System.EventHandler(this.linearGradientToolStripMenuItem_Click);
            // 
            // pathGradientToolStripMenuItem
            // 
            this.pathGradientToolStripMenuItem.Name = "pathGradientToolStripMenuItem";
            this.pathGradientToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.pathGradientToolStripMenuItem.Text = "Path Gradient";
            this.pathGradientToolStripMenuItem.Click += new System.EventHandler(this.pathGradientToolStripMenuItem_Click);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.customToolStripMenuItem1});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(93, 38);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem1
            // 
            this.customToolStripMenuItem1.Name = "customToolStripMenuItem1";
            this.customToolStripMenuItem1.Size = new System.Drawing.Size(269, 38);
            this.customToolStripMenuItem1.Text = "Custom";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(269, 38);
            this.toolStripMenuItem2.Text = "50%";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(269, 38);
            this.toolStripMenuItem3.Text = "100%";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(269, 38);
            this.toolStripMenuItem4.Text = "200%";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 1069);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pensTabPage;
        private System.Windows.Forms.TabPage brushesTabPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathGradientToolStripMenuItem;
        private System.Windows.Forms.TabPage imagePanningTabPage;
        private System.Windows.Forms.TabPage shapesAndTextTabPage;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

