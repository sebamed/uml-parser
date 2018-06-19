using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlDiagram.model
{
    public class Property
    {

        private string name;
        private string accessor;
        private string dataType;

        public Property()
        {

        }

        public Property(string accessor, string dataType, string name)
        {
            this.name = name;
            this.accessor = accessor;
            this.dataType = dataType;
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

        public void setDataType(string dataType)
        {
            this.dataType = dataType;
        }

        public string getDataType()
        {
            return this.dataType;
        }
    }
}
