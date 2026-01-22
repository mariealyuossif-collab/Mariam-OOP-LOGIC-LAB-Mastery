using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class number
    {
        public int x;
        public float c;
        public number()
        {
            this.x = 12;
            this.c = 17;
        }
        public void show()
        {
            Console.WriteLine("int number" + this.x + "float nuber" + this.c);
        }
        public number(int v1, float v2)
        {
            this.x = v1;
            this.c = v2;
        }


    }
}
