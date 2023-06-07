using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4.UI
{
    class rectangle_
    {
        public static object data()
        {
            Console.WriteLine("Enter the height: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            float width = float.Parse(Console.ReadLine());
            rectangel r = new rectangel(height, width, "Rectangle");
            return r;
        }
    }
}
