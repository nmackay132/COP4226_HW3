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
using System.Security.Cryptography;

namespace HW3
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();
            doc = new Document();
            bufferContext = new BufferedGraphicsContext();
            bufferContext.MaximumBuffer = this.ClientRectangle.Size;
        }

        #region Fields

        private BufferedGraphicsContext bufferContext;
        private Pen pen;
        private DashStyle dashStyle;
        private float[] dashPattern;

        private System.Drawing.Brush brush;
        private Document doc;

        #endregion

        #region MainForm

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem menuItem in this.menuStrip1.Items)
            {
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
            else if (tabControl.SelectedTab == tabControl.TabPages["shapesAndTextTabPage"])
            {
                shapeToolStripMenuItem.Visible = true;
                zoomToolStripMenuItem.Visible = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabControl_SelectedIndexChanged(sender, e);
        }

        private void checkMenuItem(ToolStripMenuItem childMenu, ToolStripMenuItem parentMenu)
        {
            foreach (ToolStripMenuItem menuItem in parentMenu.DropDownItems)
            {
                menuItem.Checked = false;
            }
            childMenu.Checked = true;
        }

        #endregion

        #region PenTab

        private void pensTabPage_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            int x = tabControl.Left, y = tabControl.Top;
            int width = this.tabControl.ClientRectangle.Width / 2;
            int height = this.tabControl.ClientRectangle.Height / 2;
            using (pen = new Pen(Color.SpringGreen, 12)) {
                pen.DashStyle = dashStyle;
                if (dashStyle == DashStyle.Custom) {
                    pen.DashPattern = dashPattern;
                }
                if (pen.DashStyle == DashStyle.Dash)
                {
                    pen.CompoundArray = new float[] {0.0f, 0.25f, 0.75f, 1.0f};
                }
                g.DrawLine(pen, x, y, x + width, y + height);
            }
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e) {
            dashStyle = DashStyle.Solid;
            this.Invalidate(true);
            checkMenuItem(solidToolStripMenuItem, pensToolStripMenuItem);
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e) {
            dashStyle = DashStyle.Custom;
            dashPattern = new float[] { 1f, 1f, 2f, 1f, 1f, 2f, 1f, 1f };
            this.Invalidate(true);
            checkMenuItem(customToolStripMenuItem, pensToolStripMenuItem);
        }

        private void compoundToolStripMenuItem_Click(object sender, EventArgs e) {
            dashStyle = DashStyle.Dash;
            this.Invalidate(true);
            checkMenuItem(compoundToolStripMenuItem, pensToolStripMenuItem);
        }

        #endregion

        #region Brush Tab

        enum BrushType { Solid, Texture, Hatch, LinearGradient, PathGradient };

        BrushType brushType;

        private void brushesTabPage_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            int x = tabControl.Left + 100, y = tabControl.Top + 100 ;
            int width = this.tabControl.ClientRectangle.Width / 2;
            int height = this.tabControl.ClientRectangle.Height / 4;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);

            switch (brushType)
            {
                case BrushType.Solid:
                    Color myColor = Color.FromArgb(25, 100, 100, 150);
                    using (brush = new SolidBrush(myColor))
                    {
                        g.FillRectangle(brush, x, y, width, height);
                    }
                    break;
                case BrushType.Texture:
                    using (brush = new TextureBrush(new Bitmap(Properties.Resources.grunge_texture_18536)))
                    {
                        g.FillRectangle(brush, x, y, width, height);
                    }
                    break;
                case BrushType.Hatch:
                    using (brush = new HatchBrush(HatchStyle.Plaid, Color.RoyalBlue, Color.Plum))
                    {
                        g.FillRectangle(brush, rect);
                    }
                    break;
                case BrushType.LinearGradient:
                    using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Red, Color.Blue, 45.0f)) {
                        ColorBlend blend = new ColorBlend();
                        blend.Colors = new [] {Color.Red, Color.Blue, Color.Green};
                        blend.Positions = new[] {0.0f, 0.3f, 1.0f};
                        brush.InterpolationColors = blend;
                        g.FillRectangle(brush, rect);
                    }
                    break;
                case BrushType.PathGradient:
                    //typeToolStripStatusLabel.Text = "Type: PathGradient";
                    PointF[] points =
                    {
                        new PointF(x + width/2, y), new PointF(x, y + height),
                        new PointF(x + width, y + height),
                        new PointF(x, y + 10),
                    };
                    using (GraphicsPath circle = new GraphicsPath())
                    {
                        circle.AddEllipse(rect);
                        using (PathGradientBrush brush2 = new PathGradientBrush(points))
                        {
                            brush2.WrapMode = WrapMode.Tile;
                            brush2.SurroundColors = new Color[] { Color.Red, Color.Blue, Color.Green };
                            brush2.CenterColor = Color.Black;
                            g.FillRectangle(brush2, rect);
                        }
                    }
                    break;
            }
        }

        private void solidToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            brushType = BrushType.Solid;
            Invalidate(true);
        }

        private void textureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushType = BrushType.Texture;
            Invalidate(true);
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushType = BrushType.Hatch;
            Invalidate(true);
        }

        private void linearGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushType = BrushType.LinearGradient;
            Invalidate(true);
        }

        private void pathGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brushType = BrushType.PathGradient;
            Invalidate(true);
        }

        #endregion

        #region Image Panning Tab

        private int offsetWidth = 450, offsetHeight = 80;
        private BufferedGraphics frame;

        private void displayImage()
        {
            Graphics g = CreateGraphics();
            using (frame = bufferContext.Allocate(g, tabControl.ClientRectangle))
            {
                //frame = bufferContext.Allocate(g, tabControl.ClientRectangle);
                System.Drawing.Rectangle destRect = this.panningPanel.ClientRectangle;
                destRect.Location = this.panningPanel.Location;
                System.Drawing.Rectangle srcRect = new System.Drawing.Rectangle(offsetWidth, offsetHeight, 1000, 1000);
                frame.Graphics.DrawImage(Properties.Resources.GameOfThrones, destRect, srcRect, g.PageUnit);
                frame.Render();
            }
        }

        private void imagePanningTabPage_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            System.Drawing.Rectangle destRect = this.panningPanel.ClientRectangle;
            destRect.Location = this.panningPanel.Location;
            using (pen = new Pen(Color.Red, 5))
            {
                g.DrawRectangle(pen, destRect);
            }
        }

        private bool mouseIsDown = false;
        private Point mouseDownLoc;

        private void panningPanel_MouseDown(object sender, MouseEventArgs e) {
            displayImage();
            mouseIsDown = true;
            mouseDownLoc = e.Location;
            //frame.Render();
        }

        private void panningPanel_MouseMove(object sender, MouseEventArgs e) {
            if (mouseIsDown) {
                int dx = mouseDownLoc.X - e.Location.X;
                int dy = mouseDownLoc.Y - e.Location.Y;
                offsetWidth += dx;
                offsetHeight += dy;
                displayImage();
                mouseDownLoc = e.Location;
            }
            //frame.Render();
        }

        private void panningPanel_MouseUp(object sender, MouseEventArgs e) {
            mouseIsDown = false;
            //bufferContext.Dispose();
        }

        #endregion

        #region Shapes and Text Tab

        private float pageScale = 1;
        private Matrix matrix = new Matrix();

        private void MakeRandomInput(out int x, out int y, out int width, out int height, out Color color) {
            Random rand = new Random();
            width = rand.Next(50, 300);
            height = rand.Next(50, 300);
            x = rand.Next(this.tabControl.ClientRectangle.Left, this.tabControl.ClientRectangle.Right - width);
            y = rand.Next(this.tabControl.ClientRectangle.Top, this.tabControl.ClientRectangle.Bottom - height);
            color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
        }

        private void updateShapeStatus(string shape)
        {
            shapeToolStripStatusLabel1.Text = "Shape: " + shape;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e) {
            int x, y, width, height;
            Color color;
            MakeRandomInput(out x, out y, out width, out height, out color);
            Rectangle rect = new Rectangle(x, y, width, height, color);
            doc.AddShape(rect);
            updateShapeStatus("Rectangle");
            this.Invalidate(true);
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e) {
            int x, y, width, height;
            Color color;
            MakeRandomInput(out x, out y, out width, out height, out color);
            Ellipse ellipse = new Ellipse(x, y, width, height, color);
            doc.AddShape(ellipse);
            updateShapeStatus("Ellipse");
            this.Invalidate(true);
        }

        private void shapesAndTextTabPage_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            //doc.DrawShapes(pen, g);
            g.Transform = matrix;
            doc.FillShapes(brush, g);
        }

        private void zoom50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix.Scale(0.5f, 0.5f);
            this.Invalidate(true);
        }

        private void zoom100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix.Scale(1, 1);
            this.Invalidate(true);
        }

        private void zoom200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix.Scale(2, 2);
            this.Invalidate(true);
        }

        private PointF mouseDownPoint;
        private bool isMouseDown;
        private Shape movingShape;
        private Point shapeStartLoc;

        private void shapesAndTextTabPage_MouseDown(object sender, MouseEventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                g.PageScale = pageScale;
                PointF[] pointF = {new PointF(e.X, e.Y)};
                g.TransformPoints(CoordinateSpace.World, CoordinateSpace.Device, pointF);
                Shape shape = doc.Find(pointF[0], g);
                if (shape != null)
                {
                    //mouseDownPoint = e.Location;
                    mouseDownPoint = pointF[0];
                    isMouseDown = true;
                    movingShape = shape;
                    shapeStartLoc = shape.Location;
                }
            }
        }

        private void moveShape(MouseEventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                //g.PageScale = pageScale;
                //PointF[] ePointF = { new PointF(e.X, e.Y) };
                //g.TransformPoints(CoordinateSpace.World, CoordinateSpace.Device, ePointF);
                //Point newLoc = new Point();
                //int dx = e.X - mouseDownPoint.X;
                //int dy = e.Y - mouseDownPoint.Y;
                //newLoc.X = shapeStartLoc.X + dx;
                //newLoc.Y = shapeStartLoc.Y + dy;
                //movingShape.Location = newLoc;
                //Invalidate(true);

                g.PageScale = pageScale;
                PointF[] eF = { new PointF(e.X, e.Y) };
                PointF[] shapeStartLocF = { new PointF(shapeStartLoc.X, shapeStartLoc.Y) };
                g.TransformPoints(CoordinateSpace.World, CoordinateSpace.Device, eF);
                PointF newLocF = new PointF();
                float dx = eF[0].X - mouseDownPoint.X;
                float dy = eF[0].Y - mouseDownPoint.Y;
                newLocF.X = shapeStartLocF[0].X + dx;
                newLocF.Y = shapeStartLocF[0].Y + dy;
                //locToolStripStatusLabel1.Text = "Mouse Location: " + eF[0].X + ", " + eF[0].Y;
                g.TransformPoints(CoordinateSpace.Device, CoordinateSpace.World, new PointF[] {newLocF});
                Point newLoc = new Point((int) newLocF.X, (int) newLocF.Y);
                movingShape.Location = newLoc;
                Invalidate(true);
            }
        }

        private void shapesAndTextTabPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                moveShape(e);
            }
            //locToolStripStatusLabel1.Text = "Mouse Location: " + e.X + ", " + e.Y;
        }

        private void shapesAndTextTabPage_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                moveShape(e);
                isMouseDown = false;
            }
        }

        #endregion
    }
}
