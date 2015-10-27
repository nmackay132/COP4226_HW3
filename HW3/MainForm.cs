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
            doc = new Document();
        }

        #region Fields
        private Pen pen;
        private DashStyle dashStyle;
        private float[] dashPattern;

        private Brush brush;
        private Document doc;
        #endregion

        #region PenTab
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
            if (tabControl.SelectedTab == tabControl.TabPages["pensTabPage"])
            {
                pensToolStripMenuItem.Visible = true;                
            }
            else if (tabControl.SelectedTab == tabControl.TabPages["brushesTabPage"])
            {
                brushToolStripMenuItem.Visible = true;                
            }
            else if (tabControl.SelectedTab == tabControl.TabPages["shapesAndTextTabPage"]) {
                shapeToolStripMenuItem.Visible = true;
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
        #endregion

        #region Brush Tab
        enum BrushType { Solid, Texture, Hatch, LinearGradient, PathGradient };

        BrushType brushType;

        private void brushesTabPage_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            int x = tabControl.Left, y = tabControl.Top;
            int width = this.tabControl.ClientRectangle.Width / 2;
            int height = this.tabControl.ClientRectangle.Height / 2;

            switch (brushType)
            {
                case BrushType.Solid:
                    Color myColor = Color.FromArgb(0, 100, 100, 100);
                    using (brush = new SolidBrush(myColor))
                    {
                        g.FillRectangle(brush, x, y, width, height);
                    }
                    break;
                case BrushType.Texture:
                    //MessageBox.Show(brushType.ToString());
                    using (brush = new TextureBrush(new Bitmap(Properties.Resources.grunge_texture_18536)))
                    {
                        g.FillRectangle(brush, x, y, width, height);
                    }
                    break;
                case BrushType.Hatch:
                    break;
                case BrushType.LinearGradient:
                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);
                    using (brush = new LinearGradientBrush(rect, Color.Blue, Color.Red, 20.0f)) {
                        g.FillRectangle(brush, rect);
                    }
                    break;
                case BrushType.PathGradient:
                    break;
            }
        }

        private void solidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            brushType = BrushType.Solid;
        }

        private void textureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushType = BrushType.Texture;
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushType = BrushType.Hatch;
        }

        private void linearGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushType = BrushType.LinearGradient;
        }

        private void pathGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushType = BrushType.PathGradient;
        }
        #endregion

        #region Image Panning Tab
        private int offsetWidth = 450, offsetHeight = 80;
        private void imagePanningTabPage_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Rectangle destRect = this.panningPanel.ClientRectangle;
            destRect.Location = this.panningPanel.Location;
            //MessageBox.Show(destRect.ToString());
            System.Drawing.Rectangle srcRect = new System.Drawing.Rectangle(offsetWidth, offsetHeight, 1000, 1000);
            //g.DrawImage(new Bitmap(Properties.Resources.GameOfThrones), rect) ;
            g.DrawImage(new Bitmap(Properties.Resources.GameOfThrones), destRect, srcRect, g.PageUnit);
            using (pen = new Pen(Color.Red, 5))
            {
                g.DrawRectangle(pen, destRect);
            }
        }

        private bool mouseIsDown = false;
        private Point mouseDownLoc;

        private void panningPanel_MouseDown(object sender, MouseEventArgs e) {
            mouseIsDown = true;
            mouseDownLoc = e.Location;
            //MessageBox.Show("Mouse Down " + this.panningPanel.Location.ToString());
        }

        private void panningPanel_MouseMove(object sender, MouseEventArgs e) {
            if (mouseIsDown) {
                int dx = mouseDownLoc.X - e.Location.X;
                int dy = mouseDownLoc.Y - e.Location.Y;
                //if (Math.Abs(dx) > 15 || Math.Abs(dy) > 15) {
                    offsetWidth += dx;
                    offsetHeight += dy;
                    panningPanel.Invalidate();
                    mouseDownLoc = e.Location;
                //}
            }
        }

        private void panningPanel_MouseUp(object sender, MouseEventArgs e) {
            mouseIsDown = false;
        }

        #endregion

        #region Shapes and Text Tab

        private void MakeRandomInput(out int x, out int y, out int width, out int height, out Color color) {
            Random rand = new Random();
            width = rand.Next(50, 300);
            height = rand.Next(50, 300);
            x = rand.Next(this.tabControl.ClientRectangle.Left, this.tabControl.ClientRectangle.Right - width);
            y = rand.Next(this.tabControl.ClientRectangle.Top, this.tabControl.ClientRectangle.Bottom - height);
            color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e) {
            int x, y, width, height;
            Color color;
            MakeRandomInput(out x, out y, out width, out height, out color);
            Rectangle rect = new Rectangle(x, y, width, height, color);
            doc.AddShape(rect);
            this.Invalidate(true);
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e) {
            int x, y, width, height;
            Color color;
            MakeRandomInput(out x, out y, out width, out height, out color);
            Ellipse ellipse = new Ellipse(x, y, width, height, color);
            doc.AddShape(ellipse);
            this.Invalidate(true);
        }

        private void shapesAndTextTabPage_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            doc.DrawShapes(pen, g);
        }

        #endregion

    }
}
