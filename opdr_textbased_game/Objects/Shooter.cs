using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdr_textbased_game.Objects
{
    class Shooter : Knight
    {
        private int range;
        public Shooter(int range, string name, int age, float power, string quote) : base(name, age, power, quote)
        {
            this.range = range;
        }

        public  string getNameAndRange()
        {
            return name + " has specific range: " + range;
        }
    }
}
