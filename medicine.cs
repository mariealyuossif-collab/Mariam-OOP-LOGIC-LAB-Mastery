using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class medicine
    {
        public string name;
        private double price;
        public int qauntity;
        public medicine()
        {
            Console.WriteLine("A drug was added to the system");
        }
        public string Name { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    price = 5;
                }
            }
        }
        public void printdata()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Price: " + this.price);
        }
                



    }
}
