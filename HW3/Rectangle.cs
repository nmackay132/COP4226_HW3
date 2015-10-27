using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
            int width = Size.Width;
            int height = Size.Height;
            g.DrawRectangle(pen, x, y, width, height);
        }

        public override void Fill(Brush brush, Graphics g) {
            g.FillRectangle(brush, Location.X, Location.Y, Size.Width, Size.Height);
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
