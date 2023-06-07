using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class person
    {
        protected string name;
        protected string address;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }

        public person(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public virtual string tostring()
        {
            return "person[Name: " + name + " address " + address+"]";
        }
    }
}
