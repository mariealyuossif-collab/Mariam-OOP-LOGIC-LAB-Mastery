using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class publication
    {
        public string title;
        public double price;
        public string Title { get; set; }
        public double Price
        { get { return price; } set { if (price <= 0) { price = 10; }
                else {
                    price = value;
                        }
            }
        }
        public publication()
        {
            Console.WriteLine("A nww version is being added to the library");
        }
        public void display()
        {
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine("Title: " + this.Title);
        }
                        
                        
                        
        


    }
}
