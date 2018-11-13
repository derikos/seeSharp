using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp.MyAlgorithms
{
   public abstract class Furniture
    {
        private string Name ;

        protected Furniture(string n)
        {
            this.Name = n;
        }

        protected abstract void displayName();
    }
}
