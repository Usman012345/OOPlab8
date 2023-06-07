using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    class animal
    {
        protected string name;
        public animal(string name)
        {
            this.name = name;
        }
        public virtual void greets()
        {
            ;
        }
        public virtual string tostring()
        {
            return "Animal[name: " + name+"]";
        }
    }
}
