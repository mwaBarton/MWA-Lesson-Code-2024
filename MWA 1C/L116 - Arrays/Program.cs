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
            string[] names = new string[3];
            int[] numbers = new int[10];

            names[0] = "Bob";
            names[1] = "Joe";
            names[2] = "Diane";

            Console.WriteLine(names[1]);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string name in names) {
                Console.WriteLine(name);
            }

            string[] names2 = { "Bob", "Joe", "Diane" };

            for (int i = 0; i < names2.Length; i++) {
                Console.Write($"Enter name {i+1}: ");
                names2[i] = Console.ReadLine();
            }

            foreach (string name in names2) {
                Console.Write(name + ", ");
            }


            Console.ReadKey();
        }
    }
}
