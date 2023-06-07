using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.BL;
using task2.DL;
using task2.UI;

namespace task2
{
    class Program
    { 
        static void Main(string[] args)
        {
            string name,address,program,school;
            int year;
            double fee,pay;
            
           
            for (int x=0;x<4;x++)
            {
                write.write_("Enter the name");
                name=Console.ReadLine();
                write.write_("Enter address");
                address = Console.ReadLine();
                if (x < 2)
                {
                    write.write_("Enter fee");
                    fee = double.Parse(Console.ReadLine());
                    write.write_("Enter year");
                    year = int.Parse(Console.ReadLine());
                    write.write_("Enter program");
                    program = Console.ReadLine();
                    student sss = new student(name, address, program, year, fee);
                    data_student.add(sss);
                    print.print_(sss);
                }
                else
                {
                    write.write_("Enter school");
                    school = Console.ReadLine();
                    write.write_("Enter pay");
                    pay = double.Parse(Console.ReadLine());
                    staff ss = new staff(name, address, school, pay);
                    data_student.add(ss);
                    print.print_(ss);
                }
            }
            Console.ReadKey();
        }
    }
}
