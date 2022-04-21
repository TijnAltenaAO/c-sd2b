using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdr_textbased_game.Objects.SuperClass
{
    class Entity
    {
        protected string name;
        protected int power;
        protected int hp;

        public Entity(string name, int power, int hp)
        {
            this.name = name;
            this.power = power;
            this.hp = hp;
        }

        public string getName()
        {
            return name;
        }     
        public int getPower()
        {
            return power;
        }
        public int getHp()
        {
            return hp;
        }
        public string Attack(Entity target)
        {
            Console.WriteLine(name + target.name);
            return target.setDamage(power);
        }
        public string setDamage(int damage)
        {
            hp = hp - damage;
            return name + " took " + damage + " damage!";
        }
    }
}
