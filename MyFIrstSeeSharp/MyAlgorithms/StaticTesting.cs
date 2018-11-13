using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp.MyAlgorithms
{
    class StaticTesting
    {
        private static int instances = 0;

        public StaticTesting()
        {
            instances++;
        }

        public int GetNoOfInstances()
        {
            return instances;
        }

        public static int StaticMethodInstances()
        {
            return instances;
        }

        public static void PrintName(string s)
        {
            Console.WriteLine(s);
        }
        public static string ReturnStaticStringOne()
        {
            return "Hello World";
        }
        public static string ReturnStaticStringTwo()
        {
            return "Hello again";
        }

        ~StaticTesting()
        {
            instances--;
            Console.WriteLine("Destructor: " + instances);
        }
    }
}
