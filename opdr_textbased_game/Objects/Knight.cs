using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opdr_textbased_game.Objects.SuperClass;

namespace opdr_textbased_game.Objects
{
    class Knight : Entity
    {
        public float kritz;
        public Knight(float kritz, string name, int power, int hp) : base(name, power, hp)
        { 
            this.kritz = kritz;
            
        }

        public string getName()
        {
            return name;
        }

        public string setPower()
        {
            power += 3f * age;
            return "prestige " + power + "!" ;
        }

        public virtual string Yell()
        {
            return quote;
        }
    }
}
