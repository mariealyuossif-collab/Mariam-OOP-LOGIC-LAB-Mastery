using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class Tablet: medicine
    {
        public int pillscount {  get; set; }
        public void calculatepillprice()
        {
            pillscount = 15;
            Price = 19.5;
            double r = Math.Round(Price / pillscount);
            Console.WriteLine(r * 100 + "%");   
        }
    }
}
