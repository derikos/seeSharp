using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFIrstSeeSharp.FactoryPattern
{
    public abstract class EnemyShip
    {
        public string Name { get; set; }
        public double AmtDamage { get; set; }

        public void displayEnemyShip()
        {
            Console.WriteLine("Displaying ship ");
        }

        public void FollowHeroShip()
        {
            System.Console.WriteLine(this.Name + " Is following the hero");

        }

        public void EnemyShipShoots()
        {
            Console.WriteLine(this.Name + " attacks and does " + this.AmtDamage);

        }
    }
}
