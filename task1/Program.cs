using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.cylinders;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 0.0;
               double height=0.0;
            string color="";
            List<circle> cylinders = new List<circle>();
            cylinder c1 = new cylinder();
            cylinders.Add(c1);
            for(int x=1;x<3;x++)
            {
                radius = double.Parse(Console.ReadLine());
                height = double.Parse(Console.ReadLine());
                color = Console.ReadLine();
                    cylinder c = new cylinder(radius,height,color);
                cylinders.Add(c);
            }
            foreach(cylinder data in cylinders)
            {
                data.Height = double.Parse(Console.ReadLine());
                Console.WriteLine(data.volume());
            }    
            
        }
    }
}
