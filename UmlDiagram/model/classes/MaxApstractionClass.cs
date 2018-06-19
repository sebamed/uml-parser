using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDiagram.model
{
    public class MaxApstractionClass
    {

        public string name;
        public List<Property> properties;
        public List<Method> methods;
        public Rectangle classRec;

        public Brush defaultBrush = Brushes.LightGray;
        public Pen defaultPen = Pens.Black;
        public Brush defaultFontBrush = Brushes.Black;

        public MaxApstractionClass()
        {

        }

        public MaxApstractionClass(string name, int x, int y)
        {
            this.name = this.correctName(name);
            this.properties = new List<Property>();
            this.methods = new List<Method>();
            this.classRec = new Rectangle(x, y, this.name.Length*3 + 90, 30);
        }

        private string correctName(string name)
        {
            string newName = "";
            for(int i = 0; i < name.Length; i++)
            {
                if(i == 0) // first capital
                {
                    newName += name[i].ToString().ToUpper();
                    continue;
                }
                if(name[i].ToString() == " ") // space
                {
                    continue;
                }
                if(i != 1 && name[i-1].ToString() == " ")
                {
                    newName += name[i].ToString().ToUpper();
                    continue;
                }
                newName += name[i].ToString();
            }
            return newName;
        }

        public Rectangle getClassRec()
        {
            return this.classRec;
        }
        
        public void addProperty(Property property)
        {
            this.properties.Add(property);
        }

        public void addMethod(Method method)
        {
            this.methods.Add(method);
        }

        public void draw(Graphics g)
        {            
            g.FillRectangle(this.defaultBrush, this.classRec);
            g.DrawRectangle(this.defaultPen, this.classRec);
            StringFormat centeredString = new StringFormat();
            centeredString.Alignment = StringAlignment.Center;
            centeredString.LineAlignment = StringAlignment.Center;
            g.DrawString(this.name, new Font("Verdana", 11, FontStyle.Regular), this.defaultFontBrush, this.classRec, centeredString);
        }
    }
}
