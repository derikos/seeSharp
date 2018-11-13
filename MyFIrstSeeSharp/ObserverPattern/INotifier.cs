using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp.ObserverPattern
{
    interface INotifier
    {
        void register();
        void unRegister();
        void update();
    }
}
