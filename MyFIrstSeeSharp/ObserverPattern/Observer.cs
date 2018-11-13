using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp.ObserverPattern
{
    class Observer 
    {
        private int price;
        public string Name { get; set; }

        public Observer()
        {
            Console.WriteLine("THis is the Observer ctor");
        }

        public void update(int p)
        {
            Console.WriteLine("Price has been updated!");
            Console.WriteLine("Shop name: " + Name);
            price = p;
        }
    }
}
