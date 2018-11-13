using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.ObserverPattern;

namespace MyFIrstSeeSharp.ObserverPattern
{
    class Notifier
    {
        public Notifier()
        {
        }
        List<Observer> observers = new List<Observer>();
        private int price;


        public void registerObserver(Observer o)
        {
            if(!observers.Contains(o))
            {
                observers.Add(o);
            }
            else
            {
                throw new Exception("Item already registered");
            }
        }
        public void unRegisterObserver(Observer o)
        {
            if(observers.Contains(o))
            {
                observers.Remove(o);
            }
        }
        public void updatePrice(int p)
        {
            if(p != price)
            {
                price = p;
                foreach(var obs in observers)
                {
                    obs.update(price);
                }
            }
        }
    }
}
