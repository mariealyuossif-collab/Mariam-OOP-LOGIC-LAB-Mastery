using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class number
    {
        public int n1;
        public int n2;
        public number()
        {
            this.n1 = 0;
            this.n2 = 0;
        }
        public number(int v1, int v2)
        {
            this.n1 = v1;
            this.n2 = v2;

        }
        public int sub()
        {
            return (this.n1 - this.n2);
        }
        public float sum(float a, float b)
        {
            return a + b;
        }
        public float mul()
        {
            return this.n1 * this.n2;
        }
        public static float div(float c, float d)
        {
            return d / c;
        }

        public void show()
        {
            Console.WriteLine("int number" + this.n1, +this.n2);
        }
    }
}
