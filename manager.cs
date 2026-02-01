using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class manager: employee
    {
        public double bouns;
        public manager(string Name, int Salary, double Bouns) : base(Name, Salary)
        {
            this.bouns = Bouns;
        }
        public override void printinfo()
        {
            Console.WriteLine("manger:" +name);
            Console.WriteLine("Salary:" + salary);
            Console.WriteLine("Bouns:" + bouns);
        }
         

    }
}
