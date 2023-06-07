using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;
using task3.DL;
using task3.UI;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            for(int x=0;x<2;x++)
            {
                layout.write("Enter name");
                name = Console.ReadLine();
                cat c = new cat(name);
                data.add(c);
                c.greets();
                c.ToString();
                Console.ReadKey();
            }
            for (int x = 0; x < 2; x++)
            {
                layout.write("Enter name");
                name = Console.ReadLine();
                dog c = new dog(name);
                data.add(c);
                c.greets();
                c.ToString();
                Console.ReadKey();
            }
        }
    }
}
