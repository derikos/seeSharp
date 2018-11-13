using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp;
using MyFIrstSeeSharp.MyAlgorithms;

namespace MyFIrstSeeSharp.Delegates
{
    class DelegatesTesting
    {
        //delegate string pointToMethod();
        //delegate Animal pointToDog();
        //delegate void pointToAnimal(Dog d);

        delegate void CountIt();

        delegate int AddIt(int x);

        public void TestDelegates()
        {
            StaticTesting staticTesting = new StaticTesting();

            //clasic way to assign a new delegate
            // pointToMethod myDelegate = new pointToMethod(StaticTesting.PrintName);

            //compiler does work behind the scene as the above example
            //pointToMethod myDelegate = StaticTesting.PrintName;

            //can add multiple methods to the delegates' invocation list
            //myDelegate += StaticTesting.PrintName;
            //myDelegate("Alex");

            //pointToMethod myDelegate = StaticTesting.ReturnStaticStringTwo;
            //myDelegate += StaticTesting.ReturnStaticStringOne;
            //string localString = myDelegate();
            //Console.WriteLine(myDelegate());


            //pointToDog myDogDelegate = this.GetDoge;
            //pointToAnimal myAnimalDelegate = this.doVet;

            //CountIt myCountDelegate = TestCounting;
            //myCountDelegate();

            //or with anonymous founction
            //CountIt myAnonymousDelegate = delegate
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //};
            //myAnonymousDelegate();

            //AddIt myLambdaDelegate = (int x) => x + 5; //statement lambda


            //expression lambda
            AddIt myLambdaDelegate = (int x) =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Lambda loop ended");
                return x + 5;

            };



            int result = myLambdaDelegate(5);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static void TestCounting()
        {
            for(int i = 0;i < 5;i++)
            {
                Console.WriteLine(i);
            }
        }

    //    public Dog GetDoge()
    //    {
    //        return new Dog();
    //    }
    //    public void doVet(Animal a)
    //    {
    //        Console.WriteLine("Trying to understand shit");
    //    }
    //}
    //class Animal
    //{

    //}
    //class Dog : Animal
    //{

    }
}
