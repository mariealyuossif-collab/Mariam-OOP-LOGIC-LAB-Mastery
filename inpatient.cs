using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class inpatient: patient
    {
        public int Roomnumber;
        public inpatient(string name , int age , int roomnumber) : base(name, age)
        {
            this.Roomnumber = roomnumber;   
        }
        public override void printinfo()
        {
            base.printinfo();
            Console.WriteLine($"Rooomnumber: {Roomnumber}");
        }
    }
}
