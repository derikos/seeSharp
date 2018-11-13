using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.FactoryPattern;

namespace MyFIrstSeeSharp.FactoryPattern
{
    class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            this.Name = "Rocket Enemy Ship";
            this.AmtDamage = 10;
        }
    }
}
