using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.AdapterPattern;

namespace MyFIrstSeeSharp.AdapterPattern
{
    class EnemyTank : IEnemyAtacker
    {
        Random rand = new Random();
        public void assignDriver(string d)
        {
            Console.WriteLine(d + "is driving the tank!");
        }

        public void driveForward()
        {
            int movement = rand.Next(1, 5);
            Console.WriteLine("Enemy tank has moved " + movement + "spaces!");
        }

        public void fireWapon()
        {
            int attackDamage = rand.Next(1, 10);
            Console.WriteLine("Enemy tank did " + attackDamage + "damage!");
        }

    }
}
