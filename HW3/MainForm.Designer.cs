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
            this.tabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(661, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pensTabPage);
            this.tabControl.Controls.Add(this.brushesTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 42);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(661, 496);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // pensTabPage
            // 
            this.pensTabPage.Location = new System.Drawing.Point(8, 39);
            this.pensTabPage.Name = "pensTabPage";
            this.pensTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pensTabPage.Size = new System.Drawing.Size(645, 451);
            this.pensTabPage.TabIndex = 0;
            this.pensTabPage.Text = "Pens";
            this.pensTabPage.UseVisualStyleBackColor = true;
            this.pensTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.pensTabPage_Paint);
            // 
            // brushesTabPage
            // 
            this.brushesTabPage.Location = new System.Drawing.Point(8, 39);
            this.brushesTabPage.Name = "brushesTabPage";
            this.brushesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.brushesTabPage.Size = new System.Drawing.Size(645, 449);
            this.brushesTabPage.TabIndex = 1;
            this.brushesTabPage.Text = "Brushes";
            this.brushesTabPage.UseVisualStyleBackColor = true;
            this.brushesTabPage.Paint += new System.Windows.Forms.PaintEventHandler(this.brushesTabPage_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pensToolStripMenuItem,
            this.brushToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 42);
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
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.customToolStripMenuItem.Text = "Custom";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // compoundToolStripMenuItem
            // 
            this.compoundToolStripMenuItem.Name = "compoundToolStripMenuItem";
            this.compoundToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
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
            // 
            // textureToolStripMenuItem
            // 
            this.textureToolStripMenuItem.Name = "textureToolStripMenuItem";
            this.textureToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.textureToolStripMenuItem.Text = "Texture";
            // 
            // hatchToolStripMenuItem
            // 
            this.hatchToolStripMenuItem.Name = "hatchToolStripMenuItem";
            this.hatchToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.hatchToolStripMenuItem.Text = "Hatch";
            // 
            // linearGradientToolStripMenuItem
            // 
            this.linearGradientToolStripMenuItem.Name = "linearGradientToolStripMenuItem";
            this.linearGradientToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.linearGradientToolStripMenuItem.Text = "Linear Gradient";
            // 
            // pathGradientToolStripMenuItem
            // 
            this.pathGradientToolStripMenuItem.Name = "pathGradientToolStripMenuItem";
            this.pathGradientToolStripMenuItem.Size = new System.Drawing.Size(277, 38);
            this.pathGradientToolStripMenuItem.Text = "Path Gradient";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 560);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
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
    }
}

