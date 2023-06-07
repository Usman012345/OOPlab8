using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task4.DL;
using task4.BL;
using System.Threading.Tasks;

namespace task4.UI
{
    class print
    {
        public static void print_()
        {
            foreach(Shape data in liost.Shapes)
            {
                Console.WriteLine("The shape is "+data.shape_+" and it's area is "+data.area());
            }
        }
    }
}
