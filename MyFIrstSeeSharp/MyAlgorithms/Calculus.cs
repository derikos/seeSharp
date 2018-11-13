using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp.MyAlgorithms
{
    class Calculus
    {
        public Calculus()
        {
            this.doMagic();
        }

        public int testInteger { get; set; }
        protected int testProtectedInteger { get; set; }
        private int testPrivateInteger { get; set; }

        private void doMagic()
        {
            Console.WriteLine("+++++ private DoMagic method from base class ++++");
        }
        protected void doMoreMagic()
        {
            Console.WriteLine("protected DoMoreMagic method from base class");
            Console.WriteLine("Showing integer values modffied within derived class: " + this.testInteger + this.testProtectedInteger + this.testPrivateInteger);
        }
    }
}
