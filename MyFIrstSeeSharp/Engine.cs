using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.MyAlgorithms;
using MyFIrstSeeSharp.ObserverPattern;
using MyFIrstSeeSharp.DIpattern;
using MyFIrstSeeSharp.AdapterPattern;
using MyFIrstSeeSharp.SingletonPattern;
using MyFIrstSeeSharp.FactoryPattern;
using MyFIrstSeeSharp.Events;

namespace MyFIrstSeeSharp
{
    class Engine
    {
        public void MainTesting()
        {
            int testVar;
            System.Console.WriteLine("Presupun ca asa se face");
            Singleton_P singleton_P = Singleton_P.GiveInstance();
            Singleton_P anotherTry = Singleton_P.GiveInstance();
            testVar = singleton_P.giveSomeMaths();
            System.Console.Write(testVar);
            testVar = anotherTry.giveSomeMaths();
            System.Console.Write(testVar);
            bool checkMyWord = Algorithms.VerifyIfUnique("abcdfh");
            System.Console.WriteLine(checkMyWord);
            System.Console.WriteLine("Awaiting input");
            System.Console.WriteLine(Operations.addNumbers(7, 1));
            Operations.printMessage("practice makes perfect son!");
            Notifier centralPriceUnit = new Notifier();
            List<Shops> ShopsList = new List<Shops>();
            for (int i = 0; i < 5; i++)
            {
                ShopsList.Add(new Shops());
            }
            ShopsList.ElementAt(0).Name = "Profi";
            ShopsList.ElementAt(1).Name = "Lidl";
            ShopsList.ElementAt(2).Name = "ABC";
            ShopsList.ElementAt(3).Name = "Auchan";
            ShopsList.ElementAt(4).Name = "Jumbo";

            foreach (var ob in ShopsList)
            {
                centralPriceUnit.registerObserver(ob);
            }
            centralPriceUnit.updatePrice(722);

            Bar bar = new Bar();
            Magazin magazin = new Magazin();
            Client client = new Client(bar);
            Client altClient = new Client(magazin);
            client.Request();
            altClient.Request();
            System.Console.ReadLine();
        }

        public void AdapterTesting()
        {
            EnemyTank xkf = new EnemyTank();
            EnemyRobot robin = new EnemyRobot();
            IEnemyAtacker robotAdapter = new EnemyRobotAdapter(robin);

            Console.WriteLine("The robot");
            robin.reactToHuman("Benny");
            robin.walkForward();
            robin.smashWithHands();

            Console.WriteLine("The tank");
            xkf.assignDriver("Hood");
            xkf.driveForward();
            xkf.fireWapon();

            Console.WriteLine("The robot with adapter");
            robotAdapter.assignDriver("Batman");
            robotAdapter.driveForward();
            robotAdapter.fireWapon();

            Console.ReadLine();
        }

        public void EnemyShipTesting()
        {
            EnemyShip theEnemy = null;
            EnemyShipFactory enemyShipFactory = new EnemyShipFactory();
            int flag = 0;
            string userInput = "";
            do
            {
                if ((userInput == "R") || (userInput == "U") || (userInput == "B")) break;
                Console.WriteLine("What type of ship? (R/U)");
                try
                {
                    userInput = Console.ReadLine();
                    flag = 0;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    flag = 1;
                }
                catch (OverflowException e)
                {
                    flag = 1;
                    Console.WriteLine(e.Message);
                }

            } while ((flag == 1) || (userInput != "R") || (userInput != "U") || (userInput != "B"));

            theEnemy = enemyShipFactory.makeEnemyShip(userInput);
            if (theEnemy != null)
            {
                doStuffEnemy(theEnemy);
            }
        }

        public void doStuffEnemy(EnemyShip theEnemy)
        {
            theEnemy.displayEnemyShip();
            theEnemy.FollowHeroShip();
            theEnemy.EnemyShipShoots();
            Console.ReadKey();
        }

        public void testAcces()
        {
            CalculusDerivative testObject = new CalculusDerivative();
            testObject.testInteger = 3;
            testObject.showMagic();
            Console.ReadKey();
        }

        public void StaticTestingEngine()
        {
            int testLocalStaticEnginge = 0;
            StaticTesting localStatic = new StaticTesting();
            testLocalStaticEnginge = localStatic.GetNoOfInstances();
            Console.WriteLine("Static with one object : " + testLocalStaticEnginge);
            List<StaticTesting> staticListTesting = new List<StaticTesting>();
            for(int i = 0;i < 10; i++)
            {
                staticListTesting.Add(new StaticTesting());
            }
            Console.WriteLine("Static with List added: " + StaticTesting.StaticMethodInstances());

        }

        public interface IStructInterface
        {
            void doStuff();
        }

        struct Custom
        {
            public int a;
            public int b;
            public string Name { get; set; }

            public void TypeName(string s)
            {
                Console.WriteLine(s);
            }
        }
        struct CustomTwo : IStructInterface
        {
            public void doStuff()
            {
                Console.WriteLine("Struct interface use");
            }

            public CustomTwo(int q)
            {
                Console.WriteLine("Struct ctor !!!");
            }
        }

        public void StructTesting()
        {
            Custom Mystruct = new Custom();
            Mystruct.a = 2;
            Mystruct.Name = "Johan";
            Console.WriteLine("First struct: " + Mystruct.a + Mystruct.b + " " + Mystruct.Name);
            CustomTwo MySeccondStruct = new CustomTwo(3);
            MySeccondStruct.doStuff();
        }

        public void TestEvents()
        {
            DerivedHandler myMan = new DerivedHandler();
            myMan.MoMoney();
        }

    }

}
