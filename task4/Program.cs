using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task4.BL;
using task4.UI;
using task4.DL;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            circle c = (circle)circle_.intput();
            liost.add(c);
            rectangel r = (rectangel)rectangle_.data();
            liost.add(r);
            square s = (square)square_.data();
            liost.add(s);
            print.print_();
            Console.ReadKey();
        }
    }
}
