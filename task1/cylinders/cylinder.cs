using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.cylinders
{
    class cylinder:circle
    {
       private double height = 1.0;
        public cylinder()
        {
        }
        public cylinder(double radius)
        {
            base.Radius = radius;
        }
        public cylinder(double radius,double height) : base(radius)
        {
            this.height = height;
        }
        public cylinder(double radius,double height,string color):base(radius,color)
        {
            this.height = height;
        }

        public double Height { get => height; set => height = value; }
        public double volume()
        {
            return Math.PI * (Radius * Radius) * Height;
        }
        public string tostirng_c()
        {
            return "the culinder has height: " + height + " color " + Color + " volume" + volume();
        }
    }
}
