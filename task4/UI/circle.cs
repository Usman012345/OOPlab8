using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4.UI
{
    class circle_
    {
        public static object intput()
        {
            Console.WriteLine("Enter the radius: ");
            double radius =double.Parse( Console.ReadLine());
            circle c = new circle(radius,"Circle");
            return c;
            
        }
    }
}
