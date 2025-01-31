using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L149___Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Goose harold = new Goose();
            harold.height = 100;
            harold.wingspan = 30;
            harold.canFloat = true;
            harold.favouriteBread = "Tiger bread";

            Goose ben = new Goose();
            ben.height = 7000;
            ben.wingspan = -4;
            ben.canFloat = false;
            ben.favouriteBread = "German Rye bread";

            harold.Grow(5);
            ben.Grow(2000);
            ben.favouriteBread = "Poison bread";
            ben.Grow(3);

            Console.ReadKey();
        }
    }
}
