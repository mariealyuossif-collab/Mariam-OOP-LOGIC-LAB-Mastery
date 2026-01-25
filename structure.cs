using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class structure
    {
        private int id;
        private string titlename;
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Titlename
        { get { return this.titlename; }
            set { this.titlename = value; }
        }
        public int price { get; set; }
        public string instructor {  get; set; }
        public void printdata()
        {
            Console.WriteLine("structure Id: " + this.id);
            Console.WriteLine("Title: " + this.titlename);
            Console.WriteLine("instructore: " + this.instructor);
            Console.WriteLine("price after discount: " + (this.price * 100) + "%");
        }
    }
}
