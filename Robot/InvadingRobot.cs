using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class InvadingRobot
    {
        private int robot_health;
        public int Robot_Health => robot_health;

        private int robot_damage;
        public int Robot_Damage => robot_damage;

        List<BaseEntity> entities = new List<BaseEntity>();

        public LaserIntensity Laser = new LaserIntensity();

        public InvadingRobot ()
        {
            robot_damage = Laser.OFF();
        }

        public void initialize()
        {
            Console.WriteLine("");
            robot_health = 1000;
            robot_damage = Laser.Kill();
        }

        public void AttackTarget(BaseEntity Target)
        {
            if (Target.isAlive)
            {
                Target.health -= robot_damage;
                robot_health -= Target.damage;
                Console.WriteLine($"We dealth {Target.damage} to the Robot and we took {robot_damage}");
            }
            else
            {
                entities.RemoveAt(0);
            }
        }

        public void Turn()
        {
            while (entities.Count > 0)
            {
                AttackTarget(entities.First());
            }
            Console.WriteLine($"No more targets");
        }

        public void AddTarget(BaseEntity Target)
        {
            entities.Add(Target);
        }
    }
}
