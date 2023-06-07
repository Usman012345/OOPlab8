using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task4.BL;
using System.Threading.Tasks;

namespace task4.DL
{
    class liost
    {
        public static List<Shape> Shapes =new List<Shape>();
        public static void add(Shape s)
        {
            Shapes.Add(s);
        }
    }
}
