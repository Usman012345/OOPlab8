using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    class rectangel:Shape
    {
       private float height;
       private float width;
        public rectangel(float height,float width,string shape):base(shape)
        {
            this.height = height;
            this.width = width;
        }
        public float Width { get => width; set => width = value; }
        public float Height { get => height; set => height = value; }
        public override double area()
        {
            return width*height;
        }
        public override string ToString()
        {
            return "Reactangle[Shape[ shape " + shape_ + "],height " + height + " width " + width + "]";
        }
    }
}
