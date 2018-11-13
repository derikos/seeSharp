using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.FactoryPattern;

namespace MyFIrstSeeSharp.FactoryPattern
{
    class BigUFOEnemyShip : EnemyShip
    {
        public BigUFOEnemyShip()
        {
            this.Name = "Big UFO Enemy Ship";
            this.AmtDamage = 60;
        }
    }
}
