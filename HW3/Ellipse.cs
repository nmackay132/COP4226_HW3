using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW3
{
    public class Ellipse : Shape
    {
        public Ellipse(Point loc, Size size, Color color) 
            : base(loc, size, color){
        }

        public Ellipse(Point loc, int width, int height, Color color) 
            : base(loc, width, height, color) {
        }

        public Ellipse(int x, int y, int width, int height, Color color)
            : base(x, y, width, height, color) {
        }

        public override void Draw(Pen pen, Graphics g) {
            g.DrawEllipse(pen, Location.X, Location.Y, Size.Width, Size.Height);
        }

        public override void Fill(Brush brush, Graphics g) {
            g.FillEllipse(brush, Location.X, Location.Y, Size.Width, Size.Height);
        }

        public override bool ContainsPoint(PointF point) {
            float x = point.X, y = point.Y;
            if (x >= Location.X && (x <= Location.X + Size.Width) && y >= Location.Y && (y <= Location.Y + Size.Height)) {
                return true;
            }
            return false;
        }     
    }
}
