using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDiagram.model
{
    public class Method
    {

        private string name;
        private string accessor;

        public Method()
        {

        }

        public Method(string accessor, string name)
        {
            this.name = name;
            this.accessor = accessor;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setAccessor(string accessor)
        {
            this.accessor = accessor;
        }

        public string getAccessor()
        {
            return this.accessor;
        }
    }
}
