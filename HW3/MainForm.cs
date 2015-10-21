using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HW3
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();
        }

        private Pen pen;
        private DashStyle dashStyle;
        private float[] dashPattern;

        private Brush brush;

        private void pensTabPage_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            int x = tabControl.Left, y = tabControl.Top;
            int width = this.tabControl.ClientRectangle.Width / 2;
            int height = this.tabControl.ClientRectangle.Height / 2;
            using (pen = new Pen(Color.Black, 12)) {
                pen.DashStyle = dashStyle;
                if (dashStyle == DashStyle.Custom) {
                    pen.DashPattern = dashPattern;
                }
                g.DrawLine(pen, x, y, x + width, y + height);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (ToolStripMenuItem menuItem in this.menuStrip1.Items) {
                menuItem.Visible = false;
            }
            if (tabControl.SelectedTab == tabControl.TabPages["pensTabPage"])//your specific tabname
            {
                pensToolStripMenuItem.Visible = true;                
            }
            else if (tabControl.SelectedTab == tabControl.TabPages["brushesTabPage"])//your specific tabname
            {
                brushToolStripMenuItem.Visible = true;                
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            tabControl_SelectedIndexChanged(sender, e);
        }

        private void unCheckMenuItems(ToolStripMenuItem parentMenu) {
            foreach (ToolStripMenuItem menuItem in parentMenu.DropDownItems) {
                menuItem.Checked = false;
            }
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e) {
            dashStyle = DashStyle.Solid;
            this.Invalidate(true);
            unCheckMenuItems(pensToolStripMenuItem);
            solidToolStripMenuItem.Checked = true;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e) {
            dashStyle = DashStyle.Custom;
            dashPattern = new float[] { 1f, 1f, 2f, 1f, 1f, 2f, 1f, 1f };
            this.Invalidate(true);
            unCheckMenuItems(pensToolStripMenuItem);
            customToolStripMenuItem.Checked = true;
        }

        private void compoundToolStripMenuItem_Click(object sender, EventArgs e) {
            dashStyle = DashStyle.DashDot;
            this.Invalidate(true);
            unCheckMenuItems(pensToolStripMenuItem);
            compoundToolStripMenuItem.Checked = true;
        }

        private void brushesTabPage_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            int x = tabControl.Left, y = tabControl.Top;
            int width = this.tabControl.ClientRectangle.Width / 2;
            int height = this.tabControl.ClientRectangle.Height / 2;
            using (brush = new SolidBrush(Color.Red)) {
                g.FillRectangle(brush, x, y, width, height);
            }
        }
    }
}
