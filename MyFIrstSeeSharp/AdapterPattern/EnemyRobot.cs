using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp.AdapterPattern
{
    class EnemyRobot
    {
        Random rand = new Random();

        public void smashWithHands()
        {
            int attackDamage = rand.Next(1, 5);
            Console.WriteLine("Enemy robot does " + attackDamage + "damage!");
        }

        public void walkForward()
        {
            int movement = rand.Next(1, 3);
            Console.WriteLine("Enemy robot has moved " + movement + "spaces!");
        }

        public void reactToHuman(string driver)
        {
            Console.WriteLine("Enemy robot destroys " + driver);
        }
    }
}
