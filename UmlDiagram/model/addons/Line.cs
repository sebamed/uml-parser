using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDiagram.model.addons
{
    public class Line
    {
        public Point startPoint { get; set; }
        public Point endPoint { get; set; }
        public Pen pen { get; set; }
        public Color color { get; set; }

        public Line(Color color, Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.color = color;
        }

        public Line(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        public Line(Pen pen, Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.pen = pen;
        }

        public void draw(Graphics g)
        {
            g.DrawLine(this.pen, this.startPoint, this.endPoint);
        }

        public Point getCenter()
        {
            return new Point((this.startPoint.X + this.endPoint.X) / 2, (this.startPoint.Y + this.endPoint.Y) / 2);
        }

        public double length()
        {
            return Math.Sqrt(Math.Pow(endPoint.X - this.startPoint.X, 2) + Math.Pow(endPoint.Y - this.startPoint.Y, 2));
        }

        public bool contains(Point click)
        {
            double fromFirst = Math.Sqrt((Math.Pow(startPoint.X - click.X, 2) + Math.Pow(startPoint.Y - click.Y, 2)));
            double fromSecond = Math.Sqrt((Math.Pow(endPoint.X - click.X, 2) + Math.Pow(endPoint.Y - click.Y, 2)));
            if (fromFirst + fromSecond <= this.length() + 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
