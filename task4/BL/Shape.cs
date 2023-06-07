using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    class Shape
    {
        public string shape_;
        public Shape(string shape__)
        {
            this.shape_ = shape__;
        }
        public virtual double area()
        {
            return 0.0;
        }
        public virtual string tostring()
        {
            return "Shape[ shape " + shape_ + "]";
        }

    }
}
