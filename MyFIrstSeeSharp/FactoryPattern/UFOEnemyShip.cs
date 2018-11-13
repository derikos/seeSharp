using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.FactoryPattern;

namespace MyFIrstSeeSharp.FactoryPattern
{
    class UFOEnemyShip : EnemyShip
    {
        public UFOEnemyShip()
        {
            this.Name = "UFO Enemy Ship";
            this.AmtDamage = 20;
        }
    }
}
