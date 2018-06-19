using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UmlDiagram.model.addons;
using UmlDiagram.model.connections.interfaces;

namespace UmlDiagram.model.connections
{
    public class Association : Connection
    {
        public Association()
        {

        }

        public Association(string cFirst, string cSecond, string title, MaxApstractionClass fromClass, MaxApstractionClass toClass)
        {
            this.cFirst = cFirst;
            this.cSecond = cSecond;
            this.title = title;
            this.fromClass = fromClass;
            this.toClass = toClass;
            this.type = "Association";
            this.currentPen.Brush = Brushes.Green;
        }


    }
}
