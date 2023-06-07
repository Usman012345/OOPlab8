using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;

namespace task3.DL
{
    class data
    {
        public static List<animal> a = new List<animal>();
        public static void add(animal b)
        {
            a.Add(b);
        }
    }
}
