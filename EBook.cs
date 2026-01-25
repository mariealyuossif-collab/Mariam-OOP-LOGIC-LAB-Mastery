using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class EBook: publication
    {
        public double filesize;
        public EBook()
        {
            Console.WriteLine("this book is digital and takes up disk space");
        }
    }
}
