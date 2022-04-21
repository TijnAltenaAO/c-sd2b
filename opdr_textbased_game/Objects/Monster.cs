using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opdr_textbased_game.Objects.SuperClass;

namespace opdr_textbased_game.Objects
{
    class Monster   : Entity
    {
        public Monster(string name, int power, int hp) : base(name, power, hp)
        {

        }
    }
}
