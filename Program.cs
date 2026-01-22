using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            number n1 = new number(13,12,"mariam");
            number n2 = new number();
            number n3 = new number("ahmed");
            n1.name = "mariam";
            Console.WriteLine(n3.x +" " +  n3.x + " " + n3.name);
            
          
            

        }
    }
}
