using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.MyAlgorithms;

namespace MyFIrstSeeSharp.MyAlgorithms
{
    class CalculusDerivative : Calculus
    {
         
        public void showMagic()
        {
            base.testInteger = 3;
            base.testProtectedInteger = 4;
            base.doMoreMagic();
        }
    }
}
