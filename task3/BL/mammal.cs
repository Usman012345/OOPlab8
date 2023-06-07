using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    class mammal:animal
    {
        public mammal(string name):base(name)
        { 
        }
        public override string ToString()
        {
            return "Mammal[Animal[name: " + name + "]]";
        }
        public override void greets()
        {
            base.greets();
        }
    }
}
