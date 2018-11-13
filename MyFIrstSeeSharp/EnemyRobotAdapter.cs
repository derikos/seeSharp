using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFIrstSeeSharp.AdapterPattern;

namespace MyFIrstSeeSharp
{
    class EnemyRobotAdapter : IEnemyAtacker
    {
        EnemyRobot enemyRobot;
        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            enemyRobot = newRobot;
        }

        public void assignDriver(string d)
        {
            enemyRobot.reactToHuman(d);
        }

        public void driveForward()
        {
            enemyRobot.walkForward();
        }

        public void fireWapon()
        {
            enemyRobot.smashWithHands();
        }
    }
}
