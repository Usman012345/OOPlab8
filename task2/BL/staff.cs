using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class staff:person
    {
       private string school;
        private double pay;
        public staff(string name,string address,string school,double pay):base(name,address)
        {
            this.school = school;
            this.pay = pay;
        }

        public string School { get => school; set => school = value; }
        public double Pay { get => pay; set => pay = value; }
        public override string tostring()
        {
            return "Staff[person[Name: " + name + " address " + address + "],school: "+school+"pay: "+pay+"]";
        }
    }
}
