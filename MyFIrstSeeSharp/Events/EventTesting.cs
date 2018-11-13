using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp.Events
{
    public class EventTesting
    {
        public delegate void myEventHandler();
        public event myEventHandler CashEvent;

        private int cash;

        public int GetCash()
        {
            return cash;
        }

        public void SetCash(int value)
        {
            cash = value;
            if(cash >= 100)
            {
                //let subscribers know
                {
                    if (CashEvent != null)
                    {
                        CashEvent();
                    }
                }
            }
        }

        public void AddCash(int ammount)
        {
            SetCash(GetCash() + ammount);
        }
    }
}
