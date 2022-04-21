using System;
using System.Collections.Generic;
using opdr_textbased_game.Objects;

namespace opdr_textbased_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Knight Ridder = new Knight("Sjoerd", 24, 10f, "SLAVA UKRAINI! HEROIAM SLAVA!");
            Shooter Shooter = new Shooter(40, "Snoopdogg", 25, 40f, "America's most wanted!");

            List<Knight> Ridders = new List<Knight>();

            Ridders.Add(Ridder);
            Ridders.Add(Shooter);

            Console.WriteLine(Ridders[0].Yell());
            Console.WriteLine(Ridders[1].Yell());
        }
    }
}
