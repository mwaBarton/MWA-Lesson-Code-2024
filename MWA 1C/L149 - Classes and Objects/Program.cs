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
            Person luke = new Person();
            luke.age = 1;
            luke.alive = true;
            luke.eyeColour = "Brown";
            luke.Eat("Pizza");

            Person will = new Person();
            will.age = 17;
            will.alive = true;
            will.eyeColour = "Grey";
            will.Eat("Burger");
            will.Eat("Poison");
            will.Eat("Burger");

            Console.ReadKey();
        }
    }
}
