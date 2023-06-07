using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.cylinders
{
    class circle
    {
        private double radius;
        private string color;

        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public circle()
        {
        }
       public circle( double radius)
        {
            this.radius = radius;
        }
        public circle(double radius,string color)
        {
            this.radius = radius;
            this.color = color;
        }
      public double area()
        {
            return Math.PI * (radius *radius);
        }
        public string tostring()
        {
            return "The circle has radius " + radius + " and color " + color;
        }
        
    }
}
