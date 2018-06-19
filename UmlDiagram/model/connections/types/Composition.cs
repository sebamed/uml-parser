using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDiagram.model.connections.types
{
    public class Composition : Connection
    {
        public Composition()
        {

        }

        public Composition(string cFirst, string cSecond, string title, MaxApstractionClass fromClass, MaxApstractionClass toClass)
        {
            this.cFirst = cFirst;
            this.cSecond = cSecond;
            this.title = title;
            this.fromClass = fromClass;
            this.toClass = toClass;
            this.type = "Composition";
            this.currentPen.Brush = Brushes.Purple;
        }
    }
}
