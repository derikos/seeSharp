using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.Events;

namespace MyFIrstSeeSharp.Events
{
    class DerivedHandler
    {
        private EventTesting Person = new EventTesting();

        public DerivedHandler()
        {
            Person.CashEvent += Person_CashEvent;
        }

        public void MoMoney()
        {
            
            Person.SetCash(100);
        }

        private void Person_CashEvent()
        {
            //this what imma do when i get notified about dude gettin money
            Console.WriteLine("Now that you got money...Time to pay mofo");
        }
    }
}
