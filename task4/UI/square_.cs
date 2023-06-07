using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4.UI
{
    class square_
    {
        public static object data()
        {
            Console.WriteLine("Enter side:");
            float side = float.Parse(Console.ReadLine());
            square s = new square(side,"Square");
            return s;
        }
    }
}
