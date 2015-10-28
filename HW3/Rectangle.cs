using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;

namespace HW3
{
    public class Rectangle : Shape
    {
        public Rectangle(Point loc, Size size, Color color) 
            : base(loc, size, color){
        }

        public Rectangle(Point loc, int width, int height, Color color) 
            : base(loc, width, height, color) {
        }

        public Rectangle(int x, int y, int width, int height, Color color) 
            : base(x, y, width, height, color) {
        }

        public override void Draw(Pen pen, Graphics g) {
            int x = Location.X;
            int y = Location.Y;
            //PointF[] pointF = { new PointF(Location.X, Location.Y) };
            //g.TransformPoints(CoordinateSpace.Page, CoordinateSpace.Device, pointF);
            int width = Size.Width;
            int height = Size.Height;
            //g.DrawRectangle(pen, pointF[0].X, pointF[0].Y, width, height);
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);
            g.DrawRectangle(pen, rect);
            using (Brush brush = new SolidBrush(Color.Black)) {
                string text = "This is a test";
                g.DrawString(text, new Font("Arial", 12), brush, rect);
            }
        }

        public override void Fill(Brush brush, Graphics g) {
            int x = Location.X;
            int y = Location.Y;
            int width = Size.Width;
            int height = Size.Height;
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(x, y, width, height);
            g.FillRectangle(brush, rect);
            using (StringFormat format = new StringFormat()) {
                format.Trimming = StringTrimming.EllipsisWord;
                brush = new SolidBrush(Color.Black);
                string text = "This is a test";
                g.DrawString(text, new Font("Arial", 12), brush, rect);
            }
        }

        public override bool ContainsPoint(PointF point, Graphics g) {
            float x = point.X, y = point.Y;
            PointF[] pointF = { new PointF(Location.X, Location.Y) };
            g.TransformPoints(CoordinateSpace.Page, CoordinateSpace.Device, pointF);
            if (x >= pointF[0].X && (x <= pointF[0].X + Size.Width) && y >= pointF[0].Y && (y <= pointF[0].Y + Size.Height))
            {
                return true;
            }
            return false;
        }  
    }
}
