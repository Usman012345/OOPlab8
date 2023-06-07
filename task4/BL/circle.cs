using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    class circle:Shape
    {
       private double radius;

        public double Radius { get => radius; set => radius = value; }
        public circle(double radius,string shape):base(shape)
        {
            this.radius = radius;
        }
        public override double area()
        {
            return Math.PI * (radius * radius);
        }
        public string tostring()
        {
            return "Circle[Shape[ shape " + shape_ + "],radius "+radius+"]";
        }
    }
}
