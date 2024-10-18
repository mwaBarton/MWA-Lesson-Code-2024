using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L116___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruit;
            fruit = new string[3];

            fruit[0] = "Apple";
            fruit[1] = "Banana";
            fruit[2] = "Dragonfruit";

            fruit = new string[] { "Apple", "Banana", "Dragonfruit" };

            for (int i = 0; i < fruit.Length; i++)
            {
                Console.Write($"Enter fruit {i+1}: ");
                fruit[i] = Console.ReadLine();
            }

            foreach (string f in fruit) {
                Console.Write(f + ", ");
            }


            Console.ReadKey();
        }
    }
}
