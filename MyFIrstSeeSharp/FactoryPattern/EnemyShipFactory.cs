using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.FactoryPattern;

namespace MyFIrstSeeSharp.FactoryPattern
{
    class EnemyShipFactory
    {
        public EnemyShipFactory()
        {

        }

        public EnemyShip makeEnemyShip(string userInput)
        {
            EnemyShip theEnemy = null;
            switch (userInput)
            {
                case "R":
                    {
                        theEnemy = new RocketEnemyShip();
                        break;
                    }
                case "U":
                    {
                        theEnemy = new UFOEnemyShip();
                        break;
                    }
                case "B":
                    {
                        theEnemy = new BigUFOEnemyShip();
                        break;
                    }

                default:
                    break;
            }
            return theEnemy;
        }
    }
}
