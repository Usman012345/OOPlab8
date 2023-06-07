using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task3.UI;
using System.Threading.Tasks;

namespace task3.BL
{
    class dog:mammal
    {
        public dog(string name):base(name)
        {

        }
        public override void greets()
        {
            layout.write("woof");
        }
        public override string tostring()
        {
            return "dog[Mammal[Animal[name: " + name + "]]]";
        }
    }
}
