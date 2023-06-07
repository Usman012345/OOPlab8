using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.BL
{
    class student :person
    {
        private string program;
        private int year;
        private double fee;
        public student(string name,string address,string program,int year,double fee):base(name,address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public string Program { get => program; set => program = value; }
        public int Year { get => year; set => year = value; }
        public double Fee { get => fee; set => fee = value; }
        public override string ToString()
        {
            return "Student [person[Name: " + base.name + " address " + address + "],program: "+program+" year: "+year+" fee: "+fee+"]";
        }
    }
}
