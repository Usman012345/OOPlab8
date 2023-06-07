using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.UI;

namespace task3.BL
{
    class cat:mammal
    {
        public cat(string name):base(name)
        {

        }
        public override void greets()
        {
            layout.write("meow");
        }
        public override string ToString()
        {
            return "cat[Mammal[Animal[name: " + name + "]]]";
        }
    }
}
