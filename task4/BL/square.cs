using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    class square:Shape
    {
        private float side;

        public square(float side,string shape):base(shape)
        {
            this.side = side;
        }
        public override double area()
        {
            return side*side;
        }
        public float Side { get => side; set => side = value; }
        public override string tostring()
        {
            return "Circle[Shape[ shape " + shape_ + "],side "+side+"]";
        }
    }
}
