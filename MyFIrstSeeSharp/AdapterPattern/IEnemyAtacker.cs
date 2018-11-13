using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp.AdapterPattern
{
    interface IEnemyAtacker
    {
        void fireWapon();
        void driveForward();
        void assignDriver(string d);
    }
}
