using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class patient
    {
        public string  Name;
        public int Age;
        public string  name {  get; set; }
        public int age { get; set; }
        public patient(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            hospital.Patientcount++;
       
        }
        public  virtual void printinfo()
        {
            System.Console.WriteLine($"Name:{Name}");
            System.Console.WriteLine($"Age: {Age}");
        }
            

    }
}
