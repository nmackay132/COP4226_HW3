using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW3
{
    public abstract class Shape
    {
        public Shape(Point loc, Size size, Color color) {
            this.Location = loc;
            this.Size = size;
            this.Color = color;
        }

        public Shape(Point loc, int width, int height, Color color) {
            this.Location = loc;
            this.Size = new Size(width, height);
            this.Color = color;
        }

        public Shape(int x, int y, int width, int height, Color color) {
            this.Location = new Point(x, y);
            this.Size = new Size(width, height);
            this.Color = color;
        }

        public Point Location { get; set; }

        public Size Size { get; set; }

        public Color Color { get; set; }

        public abstract void Draw(Pen pen, Graphics g);

        public abstract void Fill(Brush brush, Graphics g);

        public abstract bool ContainsPoint(PointF point);
    }
}
