using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;

namespace task2.DL
{
    class data_student
    {
        public static List<person> p = new List<person>();
        public static void add(person o)
        {
            p.Add(o);
        }
        
    }
}
