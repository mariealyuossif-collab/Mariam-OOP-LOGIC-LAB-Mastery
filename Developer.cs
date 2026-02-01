using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class Developer: employee
    {
        public string language;
        public Developer(string Name, int Salary, string Language) : base(Name, Salary)
        {
            this.language = Language;
        }
        public override void printinfo()
        {
            base.printinfo();
            Console.WriteLine("Developer:" + name);
            Console.WriteLine("Salary:" + salary);
            Console.WriteLine("Language:" + language);
        }

        

    }
}
