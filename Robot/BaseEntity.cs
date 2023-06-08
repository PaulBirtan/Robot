using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class BaseEntity
    {
        public int health { get; set; }

        public int damage { get; set; }

        public string name { get; set; }

        public BaseEntity(int health, int damage, string name)
        {
            this.health = health;
            this.damage = damage;
            this.name = name;
        }

        public bool isAlive => health > 0;
    }
}
