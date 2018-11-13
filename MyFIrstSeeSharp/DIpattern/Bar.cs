using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.DIpattern;

namespace MyFIrstSeeSharp.DIpattern
{
    class Bar : IService
    {
        public void Serve()
        {
            Console.WriteLine("You got served alcohol");
        }
    }
}
