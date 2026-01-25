using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Book: publication
    {
        public int pagecount;
        
        public void Costperpage()
        {

             double costperpage =  Math.Round(price / pagecount);
            Console.WriteLine(costperpage);
        }


    }
}
