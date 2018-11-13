using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.ObserverPattern;

namespace MyFIrstSeeSharp.ObserverPattern
{
    class Shops : Observer
    {
       public Shops()
        {
            Console.WriteLine("This is the shop ctor");
        }
    }
}
