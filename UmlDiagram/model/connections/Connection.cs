using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UmlDiagram.model.addons;

namespace UmlDiagram.model
{
    public abstract class Connection
    {
        private Point startingPoint;
        private Point endingPoint;
        private Rectangle firstRectangle;
        private Rectangle secondRectangle;

        protected List<Line> connectionLines;
        public MaxApstractionClass fromClass = new MaxApstractionClass();
        public MaxApstractionClass toClass = new MaxApstractionClass();

        public string cFirst;
        public string cSecond;
        public string title;
        public string type;

        private Font currentFont = new Font("Verdana", 8, FontStyle.Regular);

        protected Pen currentPen = new Pen(Brushes.Black);

        public void drawText(Graphics g)
        {
            if (this.connectionLines.Count == 3) // tri linije
            {
                g.DrawString(this.cFirst, this.currentFont, this.currentPen.Brush, new Line(this.connectionLines[0].startPoint, this.connectionLines[0].getCenter()).getCenter());
                g.DrawString(this.cSecond, this.currentFont, this.currentPen.Brush, new Line(this.connectionLines[2].endPoint, this.connectionLines[2].getCenter()).getCenter());
                g.DrawString(this.title, this.currentFont, this.currentPen.Brush, this.connectionLines[1].getCenter());
            }
            else if (this.connectionLines.Count == 2) // dve linije
            {
                g.DrawString(this.cFirst, this.currentFont, this.currentPen.Brush, new Line(this.connectionLines[0].startPoint, new Line(this.connectionLines[0].startPoint, this.connectionLines[0].getCenter()).getCenter()).getCenter());
                g.DrawString(this.cSecond, this.currentFont, this.currentPen.Brush, new Line(this.connectionLines[1].endPoint, this.connectionLines[1].getCenter()).getCenter());
                g.DrawString(this.title, this.currentFont, this.currentPen.Brush, new Line(this.connectionLines[0].endPoint, this.connectionLines[0].getCenter()).getCenter());
            }
            else
            {
                g.DrawString(this.cFirst, this.currentFont, this.currentPen.Brush, new Line(this.connectionLines[0].startPoint, new Line(this.connectionLines[0].startPoint, this.connectionLines[0].getCenter()).getCenter()).getCenter());
                g.DrawString(this.cSecond, this.currentFont, this.currentPen.Brush, new Line(this.connectionLines[0].endPoint, new Line(this.connectionLines[0].endPoint, this.connectionLines[0].getCenter()).getCenter()).getCenter());
                g.DrawString(this.title, this.currentFont, this.currentPen.Brush, new Line(this.startingPoint, this.endingPoint).getCenter());
            }
        }

        public void draw(Rectangle firstRec, Rectangle secondRec, Graphics g)
        {
            this.connectionLines = new List<Line>();
            this.setFirstRectangle(firstRec);
            this.setSecondRectangle(secondRec);
            // getting nearest two points
            // dots for first rect
            Point topFirstPoint = new Point(firstRec.X + firstRec.Width / 2, firstRec.Y - 1);
            Point leftFirstPoint = new Point(firstRec.X - 1, firstRec.Y + firstRec.Height / 2);
            Point bottomFirstPoint = new Point(firstRec.X + firstRec.Width / 2, firstRec.Y + firstRec.Height + 1);
            Point rightFirstPoint = new Point(firstRec.X + firstRec.Width + 1, firstRec.Y + firstRec.Height / 2);

            // dots for second
            Point topSecondPoint = new Point(secondRec.X + secondRec.Width / 2, secondRec.Y - 1);
            Point leftSecondPoint = new Point(secondRec.X - 1, secondRec.Y + secondRec.Height / 2);
            Point bottomSecondPoint = new Point(secondRec.X + secondRec.Width / 2, secondRec.Y + secondRec.Height + 1);
            Point rightSecondPoint = new Point(secondRec.X + secondRec.Width + 1, secondRec.Y + secondRec.Height / 2);

            // actual distances
            double distanceFromTop = 0;
            double distanceFromLeft = 0;
            double distanceFromRight = 0;
            double distanceFromBottom = 0;

            // check which side of rect is nearest to which

            // top one:
            Point tempWithTop = new Point();
            // left vs right in second:
            if ((Math.Pow(topFirstPoint.X - leftSecondPoint.X, 2) + Math.Pow(topFirstPoint.Y - leftSecondPoint.Y, 2)) >
                (Math.Pow(topFirstPoint.X - rightSecondPoint.X, 2) + Math.Pow(topFirstPoint.Y - rightSecondPoint.Y, 2))) // left is bigger, choosing right
            {
                tempWithTop = rightSecondPoint;
            }
            else
            {
                tempWithTop = leftSecondPoint;
            }

            if ((Math.Pow(topFirstPoint.X - tempWithTop.X, 2) + Math.Pow(topFirstPoint.Y - tempWithTop.Y, 2) >
                (Math.Pow(topFirstPoint.X - bottomSecondPoint.X, 2) + Math.Pow(topFirstPoint.Y - bottomSecondPoint.Y, 2))))
            { // nearest is bottom
                tempWithTop = bottomSecondPoint;
            }

            // setting the distance from top:
            distanceFromTop = (Math.Pow(topFirstPoint.X - tempWithTop.X, 2) + Math.Pow(topFirstPoint.Y - tempWithTop.Y, 2));

            // left one:
            Point tempWithLeft = new Point();
            // top vs bottom in second:
            if ((Math.Pow(leftFirstPoint.X - topSecondPoint.X, 2) + Math.Pow(leftFirstPoint.Y - topSecondPoint.Y, 2)) >
                (Math.Pow(leftFirstPoint.X - bottomSecondPoint.X, 2) + Math.Pow(leftFirstPoint.Y - bottomSecondPoint.Y, 2))) // top is bigger choosing bottom
            {
                tempWithLeft = bottomSecondPoint;
            }
            else
            {
                tempWithLeft = topSecondPoint;
            }
            if ((Math.Pow(leftFirstPoint.X - tempWithLeft.X, 2) + Math.Pow(leftFirstPoint.Y - tempWithLeft.Y, 2) >
                (Math.Pow(leftFirstPoint.X - rightSecondPoint.X, 2) + Math.Pow(leftFirstPoint.Y - rightSecondPoint.Y, 2))))
            { // nearest is right
                tempWithLeft = rightSecondPoint;
            }

            // setting the distance from top:
            distanceFromLeft = (Math.Pow(leftFirstPoint.X - tempWithTop.X, 2) + Math.Pow(leftFirstPoint.Y - tempWithTop.Y, 2));

            // right one:
            Point tempWithRight = new Point();
            // top vs bottom in second:
            if ((Math.Pow(rightFirstPoint.X - topSecondPoint.X, 2) + Math.Pow(rightFirstPoint.Y - topSecondPoint.Y, 2)) >
                (Math.Pow(rightFirstPoint.X - bottomSecondPoint.X, 2) + Math.Pow(rightFirstPoint.Y - bottomSecondPoint.Y, 2))) // top is bigger choosing bottom
            {
                tempWithRight = bottomSecondPoint;
            }
            else
            {
                tempWithRight = topSecondPoint;
            }

            if ((Math.Pow(rightFirstPoint.X - tempWithRight.X, 2) + Math.Pow(rightFirstPoint.Y - tempWithRight.Y, 2) >
                (Math.Pow(rightFirstPoint.X - leftSecondPoint.X, 2) + Math.Pow(rightFirstPoint.Y - leftSecondPoint.Y, 2))))
            { // nearest is left
                tempWithRight = leftSecondPoint;
            }

            // setting the distance from right:
            distanceFromRight = (Math.Pow(rightFirstPoint.X - tempWithRight.X, 2) + Math.Pow(rightFirstPoint.Y - tempWithRight.Y, 2));

            // bottom one:
            Point tempWithBottom = new Point();
            // left vs right in second:
            if ((Math.Pow(bottomFirstPoint.X - leftSecondPoint.X, 2) + Math.Pow(topFirstPoint.Y - leftSecondPoint.Y, 2)) >
                (Math.Pow(bottomFirstPoint.X - rightSecondPoint.X, 2) + Math.Pow(topFirstPoint.Y - rightSecondPoint.Y, 2))) // left is bigger, choosing right
            {
                tempWithBottom = rightSecondPoint;
            }
            else
            {
                tempWithBottom = leftSecondPoint;
            }

            if ((Math.Pow(bottomFirstPoint.X - tempWithBottom.X, 2) + Math.Pow(bottomFirstPoint.Y - tempWithBottom.Y, 2) >
                (Math.Pow(bottomFirstPoint.X - topSecondPoint.X, 2) + Math.Pow(bottomFirstPoint.Y - topSecondPoint.Y, 2))))
            { // nearest is bottom
                tempWithBottom = topSecondPoint;
            }

            // setting the distance from top:
            distanceFromBottom = (Math.Pow(bottomFirstPoint.X - tempWithBottom.X, 2) + Math.Pow(bottomFirstPoint.Y - tempWithBottom.Y, 2));

            double smallestDistance = this.compareDistances(new List<double>
            {
                distanceFromTop,
                distanceFromBottom,
                distanceFromLeft,
                distanceFromRight
            });

            int offset = 20;

            Point finalTempPointFirst = new Point();
            Point finalPointSecond = new Point();
            if (smallestDistance == distanceFromTop) // drawing line from top
            {
                finalTempPointFirst = topFirstPoint;
                finalPointSecond = tempWithTop;
                this.startingPoint = topFirstPoint;
                if (finalPointSecond == bottomSecondPoint) // top with bottom
                {
                    if (finalPointSecond.X > leftFirstPoint.X + offset && finalPointSecond.X < rightFirstPoint.X - offset) // able to be just straight line
                    {
                        Line line1 = new Line(this.currentPen, finalPointSecond, new Point(finalPointSecond.X, finalTempPointFirst.Y));
                        line1.draw(g);
                        this.connectionLines.Add(line1);
                    }
                    else
                    {
                        Point tempOne = new Point(finalPointSecond.X, finalPointSecond.Y - (finalPointSecond.Y - finalTempPointFirst.Y) / 2);
                        Point tempTwo = new Point(finalTempPointFirst.X, tempOne.Y);
                        Line line1 = new Line(this.currentPen, finalPointSecond, tempOne);
                        Line line2 = new Line(this.currentPen, tempOne, tempTwo);
                        Line line3 = new Line(this.currentPen, tempTwo, finalTempPointFirst);
                        line1.draw(g);
                        line2.draw(g);
                        line3.draw(g);
                        this.connectionLines.Add(line1);
                        this.connectionLines.Add(line2);
                        this.connectionLines.Add(line3);
                    }
                    this.endingPoint = bottomSecondPoint;
                }
                else if (finalPointSecond == leftSecondPoint || finalPointSecond == rightSecondPoint) // top with left or right
                {
                    Point tempOne = new Point(finalTempPointFirst.X, finalPointSecond.Y);
                    Line line1 = new Line(this.currentPen, finalPointSecond, tempOne);
                    Line line2 = new Line(this.currentPen, tempOne, finalTempPointFirst);
                    line1.draw(g);
                    line2.draw(g);
                    this.connectionLines.Add(line1);
                    this.connectionLines.Add(line2);
                    if (finalPointSecond == leftSecondPoint) this.endingPoint = leftSecondPoint;
                    else this.endingPoint = leftSecondPoint;
                }
            }
            else if (smallestDistance == distanceFromBottom) // drawing line with bottom
            {
                finalTempPointFirst = bottomFirstPoint;
                finalPointSecond = tempWithBottom;
                this.startingPoint = bottomFirstPoint;
                if (finalPointSecond == topSecondPoint) // top with bottom
                {
                    if (finalPointSecond.X > leftFirstPoint.X + offset && finalPointSecond.X < rightFirstPoint.X - offset) // able to be just straight line
                    {
                        Line line1 = new Line(this.currentPen, finalPointSecond, new Point(finalPointSecond.X, finalTempPointFirst.Y));
                        line1.draw(g);
                        this.connectionLines.Add(line1);
                    }
                    else
                    {
                        Point tempOne = new Point(finalPointSecond.X, finalPointSecond.Y - (finalPointSecond.Y - finalTempPointFirst.Y) / 2);
                        Point tempTwo = new Point(finalTempPointFirst.X, tempOne.Y);
                        Line line1 = new Line(this.currentPen, finalPointSecond, tempOne);
                        Line line2 = new Line(this.currentPen, tempOne, tempTwo);
                        Line line3 = new Line(this.currentPen, tempTwo, finalTempPointFirst);
                        line1.draw(g);
                        line2.draw(g);
                        line3.draw(g);
                        this.connectionLines.Add(line1);
                        this.connectionLines.Add(line2);
                        this.connectionLines.Add(line3);
                    }
                    this.endingPoint = topSecondPoint;
                }
                else if (finalPointSecond == leftSecondPoint || finalPointSecond == rightSecondPoint) // top with left or right
                {
                    Point tempOne = new Point(finalTempPointFirst.X, finalPointSecond.Y);
                    Line line1 = new Line(this.currentPen, finalPointSecond, tempOne);
                    Line line2 = new Line(this.currentPen, tempOne, finalTempPointFirst);
                    line1.draw(g);
                    line2.draw(g);
                    this.connectionLines.Add(line1);
                    this.connectionLines.Add(line2);
                    if (finalPointSecond == leftSecondPoint) this.endingPoint = leftSecondPoint;
                    else this.endingPoint = leftSecondPoint;
                }
            }
            else if (smallestDistance == distanceFromLeft) // drawing line from left
            {
                finalTempPointFirst = leftFirstPoint;
                finalPointSecond = tempWithLeft;
                this.startingPoint = leftFirstPoint;
                if (finalPointSecond == rightSecondPoint) // top with bottom
                {
                    if (finalPointSecond.Y > topFirstPoint.Y + offset / 2 && finalPointSecond.Y < bottomFirstPoint.Y - offset / 2) // able to be just straight line
                    {
                        Line line1 = new Line(this.currentPen, finalPointSecond, new Point(finalPointSecond.X, finalTempPointFirst.Y));
                        line1.draw(g);
                        this.connectionLines.Add(line1);
                    }
                    else
                    {
                        Point tempOne = new Point(finalPointSecond.X + (finalTempPointFirst.X - finalPointSecond.X) / 2, finalPointSecond.Y);
                        Point tempTwo = new Point(tempOne.X, finalTempPointFirst.Y);
                        Line line1 = new Line(this.currentPen, finalPointSecond, tempOne);
                        Line line2 = new Line(this.currentPen, tempOne, tempTwo);
                        Line line3 = new Line(this.currentPen, tempTwo, finalTempPointFirst);
                        line1.draw(g);
                        line2.draw(g);
                        line3.draw(g);
                        this.connectionLines.Add(line1);
                        this.connectionLines.Add(line2);
                        this.connectionLines.Add(line3);
                    }
                    this.endingPoint = rightSecondPoint;
                }
                else if (finalPointSecond == topSecondPoint || finalPointSecond == bottomSecondPoint) // top with left or right
                {
                    Point tempOne = new Point(finalTempPointFirst.X, finalPointSecond.Y);
                    Line line1 = new Line(this.currentPen, finalPointSecond, tempOne);
                    Line line2 = new Line(this.currentPen, tempOne, finalTempPointFirst);
                    line1.draw(g);
                    line2.draw(g);
                    this.connectionLines.Add(line1);
                    this.connectionLines.Add(line2);
                    if (finalPointSecond == topSecondPoint) this.endingPoint = topSecondPoint;
                    else this.endingPoint = bottomSecondPoint;
                }
            }
            else
            {
                finalTempPointFirst = rightFirstPoint;
                finalPointSecond = tempWithRight;
                this.startingPoint = rightFirstPoint;
                if (finalPointSecond == leftSecondPoint) // top with bottom
                {
                    if (finalPointSecond.Y > topFirstPoint.Y + offset / 2 && finalPointSecond.Y < bottomFirstPoint.Y - offset / 2) // able to be just straight line
                    {
                        Line line1 = new Line(this.currentPen, finalPointSecond, new Point(finalPointSecond.X, finalTempPointFirst.Y));
                        line1.draw(g);
                        this.connectionLines.Add(line1);
                    }
                    else
                    {
                        Point tempOne = new Point(finalPointSecond.X + (finalTempPointFirst.X - finalPointSecond.X) / 2, finalPointSecond.Y);
                        Point tempTwo = new Point(tempOne.X, finalTempPointFirst.Y);
                        Line line1 = new Line(this.currentPen, finalPointSecond, tempOne);
                        Line line2 = new Line(this.currentPen, tempOne, tempTwo);
                        Line line3 = new Line(this.currentPen, tempTwo, finalTempPointFirst);
                        line1.draw(g);
                        line2.draw(g);
                        line3.draw(g);
                        this.connectionLines.Add(line1);
                        this.connectionLines.Add(line2);
                        this.connectionLines.Add(line3);
                    }
                    this.endingPoint = leftSecondPoint;
                }
                else if (finalPointSecond == topSecondPoint || finalPointSecond == bottomSecondPoint) // top with left or right
                {
                    Point tempOne = new Point(finalPointSecond.X, finalTempPointFirst.Y);
                    Line line1 = new Line(this.currentPen, finalPointSecond, tempOne);
                    Line line2 = new Line(this.currentPen, tempOne, finalTempPointFirst);
                    line1.draw(g);
                    line2.draw(g);
                    this.connectionLines.Add(line1);
                    this.connectionLines.Add(line2);
                    if (finalPointSecond == topSecondPoint) this.endingPoint = topSecondPoint;
                    else this.endingPoint = bottomSecondPoint;
                }
            }

            // dots preview
            //g.FillRectangle(Brushes.Red, topFirstPoint.X, topFirstPoint.Y, 2, 2);
            //g.FillRectangle(Brushes.Red, leftFirstPoint.X, leftFirstPoint.Y, 2, 2);
            //g.FillRectangle(Brushes.Red, bottomFirstPoint.X, bottomFirstPoint.Y, 2, 2);
            //g.FillRectangle(Brushes.Red, rightFirstPoint.X, rightFirstPoint.Y, 2, 2);

            //g.FillRectangle(Brushes.Red, topSecondPoint.X, topSecondPoint.Y, 2, 2);
            //g.FillRectangle(Brushes.Red, leftSecondPoint.X, leftSecondPoint.Y, 2, 2);
            //g.FillRectangle(Brushes.Red, bottomSecondPoint.X, bottomSecondPoint.Y, 2, 2);
            //g.FillRectangle(Brushes.Red, rightSecondPoint.X, rightSecondPoint.Y, 2, 2);

        }

        private double compareDistances(List<double> doubleList)
        {
            double smallest = doubleList[0];
            foreach (double d in doubleList)
            {
                if (d < smallest)
                {
                    smallest = d;
                }
            }
            return smallest;
        }

        public Point getStartingPoint()
        {
            return this.startingPoint;
        }

        public void setStartingPoint(Point startingPoint)
        {
            this.startingPoint = startingPoint;
        }

        public Point getEndingPoint()
        {
            return this.startingPoint;
        }

        public void setEndingPoint(Point endingPoint)
        {
            this.endingPoint = endingPoint;
        }

        public Rectangle getFirstRectangle()
        {
            return this.firstRectangle;
        }

        public void setFirstRectangle(Rectangle firstRectangle)
        {
            this.firstRectangle = firstRectangle;
        }

        public Rectangle getSecondRectangle()
        {
            return this.secondRectangle;
        }

        public void setSecondRectangle(Rectangle secondRectangle)
        {
            this.secondRectangle = secondRectangle;
        }

        public List<Line> getConnectionLines()
        {
            return this.connectionLines;
        }

    }
}
