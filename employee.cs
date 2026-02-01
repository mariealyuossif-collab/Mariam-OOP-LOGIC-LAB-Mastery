using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class employee
    {
        protected string name;
        protected int salary;
        public employee(string Name, int Salary)
        {
            this.name = Name;
            this.salary = Salary;
        }
        public virtual void printinfo()
        {
            Console.WriteLine("Name:" + this.name);
            Console.WriteLine("Salary:" + this.salary);
        }
    }
}
