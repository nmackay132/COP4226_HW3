using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW3
{
    public class Document
    {
        private List<Shape> shapes;

        public Document() {
            shapes = new List<Shape>();
        }

        public void AddShape(Shape shape) {
            shapes.Add(shape);
        }

        public Shape Find(PointF point, Graphics g) {
            foreach (Shape shape in shapes) {
                if (shape.ContainsPoint(point, g)) {
                    return shape;
                }
            }
            return null;
        }

        public void DrawShapes(Pen pen, Graphics g) {
            foreach (Shape shape in shapes) {
                using (pen = new Pen(shape.Color)) {
                    shape.Draw(pen, g);
                }
            }
        }

        public void FillShapes(Brush brush, Graphics g) {
            foreach (Shape shape in shapes) {
                using(brush = new SolidBrush(Color.AliceBlue)){
                    shape.Fill(brush, g);
                }
            }
        }
    }
}
