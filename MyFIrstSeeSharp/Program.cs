using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.MyAlgorithms;
using MyFIrstSeeSharp.ObserverPattern;
using MyFIrstSeeSharp.DIpattern;
using MyFIrstSeeSharp.AdapterPattern;
using MyFIrstSeeSharp.Delegates;

namespace MyFIrstSeeSharp
{
    class Program
    {
        delegate string pointToMethod();

        static void Main(string[] args)
        {
            Engine testEngine = new Engine();
            //testEngine.StructTesting();
            //DelegatesTesting localTesting = new DelegatesTesting();
            //localTesting.TestDelegates();

            testEngine.TestEvents();
            Console.WriteLine("Need Mo MONEY!!");


            testEngine.TestEvents();

            Console.ReadKey();
           
        }
    }
}

