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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pensTabPage = new System.Windows.Forms.TabPage();
            this.brushesTabPage = new System.Windows.Forms.TabPage();
            this.imagePanningTabPage = new System.Windows.Forms.TabPage();
            this.panningPanel = new System.Windows.Forms.Panel();
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
            this.zoom50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.imagePanningTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(748, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pensTabPage);
            this.tabControl.Controls.Add(this.brushesTabPage);
            this.tabControl.Controls.Add(this.imagePanningTabPage);
            this.tabControl.Controls.Add(this.shapesAndTextTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(115, 18);
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(748, 481);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // pensTabPage
            // 
            this.pensTabPage.Location = new System.Drawing.Point(4, 22);
            this.pensTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.pensTabPage.Name = "pensTabPage";
            this.pensTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.pensTabPage.Size = new System.Drawing.Size(740, 455);
            this.pensTabPage.TabIndex = 0;
            this.pensTabPage.Text = "Pens";
            this.pensTabPage.UseVisualStyleBackColor = true;
            this.pensTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.pensTabPage_Paint);
            // 
            // brushesTabPage
            // 
            this.brushesTabPage.Location = new System.Drawing.Point(4, 22);
            this.brushesTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.brushesTabPage.Name = "brushesTabPage";
            this.brushesTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.brushesTabPage.Size = new System.Drawing.Size(740, 455);
            this.brushesTabPage.TabIndex = 1;
            this.brushesTabPage.Text = "Brushes";
            this.brushesTabPage.UseVisualStyleBackColor = true;
            this.brushesTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.brushesTabPage_Paint);
            // 
            // imagePanningTabPage
            // 
            this.imagePanningTabPage.Controls.Add(this.panningPanel);
            this.imagePanningTabPage.Location = new System.Drawing.Point(4, 22);
            this.imagePanningTabPage.Name = "imagePanningTabPage";
            this.imagePanningTabPage.Size = new System.Drawing.Size(740, 480);
            this.imagePanningTabPage.TabIndex = 2;
            this.imagePanningTabPage.Text = "Image Panning";
            this.imagePanningTabPage.UseVisualStyleBackColor = true;
            this.imagePanningTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.imagePanningTabPage_Paint);
            // 
            // panningPanel
            // 
            this.panningPanel.Location = new System.Drawing.Point(243, 145);
            this.panningPanel.Margin = new System.Windows.Forms.Padding(2);
            this.panningPanel.Name = "panningPanel";
            this.panningPanel.Size = new System.Drawing.Size(216, 205);
            this.panningPanel.TabIndex = 0;
            this.panningPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panningPanel_MouseDown);
            this.panningPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panningPanel_MouseMove);
            this.panningPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panningPanel_MouseUp);
            // 
            // shapesAndTextTabPage
            // 
            this.shapesAndTextTabPage.Location = new System.Drawing.Point(4, 22);
            this.shapesAndTextTabPage.Name = "shapesAndTextTabPage";
            this.shapesAndTextTabPage.Size = new System.Drawing.Size(740, 480);
            this.shapesAndTextTabPage.TabIndex = 3;
            this.shapesAndTextTabPage.Text = "Shapes and Text";
            this.shapesAndTextTabPage.UseVisualStyleBackColor = true;
            this.shapesAndTextTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.shapesAndTextTabPage_Paint);
            this.shapesAndTextTabPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.shapesAndTextTabPage_MouseDown);
            this.shapesAndTextTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.shapesAndTextTabPage_MouseMove);
            this.shapesAndTextTabPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.shapesAndTextTabPage_MouseUp);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
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
            this.pensToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.pensToolStripMenuItem.Text = "Pens";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // compoundToolStripMenuItem
            // 
            this.compoundToolStripMenuItem.Name = "compoundToolStripMenuItem";
            this.compoundToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
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
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.brushToolStripMenuItem.Text = "Brush";
            // 
            // solidToolStripMenuItem1
            // 
            this.solidToolStripMenuItem1.Name = "solidToolStripMenuItem1";
            this.solidToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.solidToolStripMenuItem1.Text = "Solid";
            this.solidToolStripMenuItem1.Click += new System.EventHandler(this.solidToolStripMenuItem1_Click);
            // 
            // textureToolStripMenuItem
            // 
            this.textureToolStripMenuItem.Name = "textureToolStripMenuItem";
            this.textureToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.textureToolStripMenuItem.Text = "Texture";
            this.textureToolStripMenuItem.Click += new System.EventHandler(this.textureToolStripMenuItem_Click);
            // 
            // hatchToolStripMenuItem
            // 
            this.hatchToolStripMenuItem.Name = "hatchToolStripMenuItem";
            this.hatchToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hatchToolStripMenuItem.Text = "Hatch";
            this.hatchToolStripMenuItem.Click += new System.EventHandler(this.hatchToolStripMenuItem_Click);
            // 
            // linearGradientToolStripMenuItem
            // 
            this.linearGradientToolStripMenuItem.Name = "linearGradientToolStripMenuItem";
            this.linearGradientToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.linearGradientToolStripMenuItem.Text = "Linear Gradient";
            this.linearGradientToolStripMenuItem.Click += new System.EventHandler(this.linearGradientToolStripMenuItem_Click);
            // 
            // pathGradientToolStripMenuItem
            // 
            this.pathGradientToolStripMenuItem.Name = "pathGradientToolStripMenuItem";
            this.pathGradientToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
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
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem1
            // 
            this.customToolStripMenuItem1.Name = "customToolStripMenuItem1";
            this.customToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.customToolStripMenuItem1.Text = "Custom";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoom50ToolStripMenuItem,
            this.zoom100ToolStripMenuItem,
            this.zoom200ToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoom50ToolStripMenuItem
            // 
            this.zoom50ToolStripMenuItem.Name = "zoom50ToolStripMenuItem";
            this.zoom50ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.zoom50ToolStripMenuItem.Text = "50%";
            this.zoom50ToolStripMenuItem.Click += new System.EventHandler(this.zoom50ToolStripMenuItem_Click);
            // 
            // zoom100ToolStripMenuItem
            // 
            this.zoom100ToolStripMenuItem.Name = "zoom100ToolStripMenuItem";
            this.zoom100ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.zoom100ToolStripMenuItem.Text = "100%";
            this.zoom100ToolStripMenuItem.Click += new System.EventHandler(this.zoom100ToolStripMenuItem_Click);
            // 
            // zoom200ToolStripMenuItem
            // 
            this.zoom200ToolStripMenuItem.Name = "zoom200ToolStripMenuItem";
            this.zoom200ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.zoom200ToolStripMenuItem.Text = "200%";
            this.zoom200ToolStripMenuItem.Click += new System.EventHandler(this.zoom200ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 552);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.imagePanningTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem zoom50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom200ToolStripMenuItem;
        private System.Windows.Forms.Panel panningPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

