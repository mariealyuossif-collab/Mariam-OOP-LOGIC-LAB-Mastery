using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class number
    {
        public int x;
        public int y;
        public string name;
        public number()
        {
            x = 0;
            y = 0;
            name = "null";
        }
        public number(int v1, int v2, string c)
        {
            x = v1;
            y = v2;
            name = c;
        }
        public number(string s)
        {
            name = s;
            x = 15;
            y = 16;
        }
        

    }
}
