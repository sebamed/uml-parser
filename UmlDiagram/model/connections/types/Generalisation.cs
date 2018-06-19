﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDiagram.model.connections.types
{
    public class Generalisation : Connection
    {
        public Generalisation()
        {

        }

        public Generalisation(string cFirst, string cSecond, string title, MaxApstractionClass fromClass, MaxApstractionClass toClass)
        {
            this.cFirst = cFirst;
            this.cSecond = cSecond;
            this.title = title;
            this.fromClass = fromClass;
            this.toClass = toClass;
            this.type = "Generalisation";
            this.currentPen.Brush = Brushes.Red;
        }
    }
}
