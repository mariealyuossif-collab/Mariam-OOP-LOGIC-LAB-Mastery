using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class outpatient:patient
    {
        public int Visitdata;
        public outpatient(string name, int age , int visitdata) : base(name, age)
        {
            Visitdata = visitdata;
        }
        public override void printinfo()
        {
            base.printinfo();
            Console.WriteLine($"Visitdata: {Visitdata}");
        }
    }
}
