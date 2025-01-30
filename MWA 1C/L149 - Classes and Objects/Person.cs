using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L149___Classes_and_Objects
{
    internal class Person
    {
        public string eyeColour;
        public bool alive;
        public int age;

        public void Eat(string foodConsumed)
        {
            if (foodConsumed == "Poison")
            {
                if (alive)
                {
                    Console.WriteLine("They drank the poison and died.");
                }
                else
                {
                    Console.WriteLine("You poured poison on a dead person.");
                }

                alive = false;
            } else if (alive)
            {
                Console.WriteLine(foodConsumed + " was eaten. It took 1 year to eat.");
                age += 1;
                Console.WriteLine("The person is now aged " + age);
            }
            else if (!alive) {
                Console.WriteLine("Nothing happened because they are dead.");
            }
        }
    }
}
