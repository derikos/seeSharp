using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.MyAlgorithms;

namespace MyFIrstSeeSharp.MyAlgorithms
{
    class Chair : Furniture
    {
        public Chair(string n) : base(n)
        { }
        protected override void displayName()
        {
            Console.WriteLine("Testing shit out");
        }
    }
}
