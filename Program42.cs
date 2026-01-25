using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bk = new Book();
            bk.Title = "luxor";
            bk.Price = -4;
            bk.pagecount = 5;
            bk.display();
            bk.Costperpage();
            EBook eB = new EBook();
            eB.Title = "qus";
            eB.Price = 67;
            eB.filesize = 2.4;
            eB.display();

        }
    }
}
