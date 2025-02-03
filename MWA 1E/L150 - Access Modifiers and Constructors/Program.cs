using System;

namespace L150___Access_Modifiers_and_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Goose harold = new Goose(6, 10, "German Rye bread");
            Goose ben = new Goose(true);

            harold.Grow(5);
            ben.Grow(2000);
            ben.MakeBadChoices();
            ben.Grow(3);

            Console.ReadKey();
        }
    }
}
