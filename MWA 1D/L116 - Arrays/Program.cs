using System;

namespace L116___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] above18;

            above18 = new bool[5];

            above18[0] = true;
            above18[1] = true;
            above18[2] = false;
            above18[3] = true;
            above18[4] = true;

            above18 = new bool[] { true, true, false, true, true };

            for (int i = 0; i < above18.Length; i++)
            {
                Console.Write($"Enter above 18 for person {i}: ");
                above18[i] = bool.Parse(Console.ReadLine());
            }

            foreach (bool a18 in above18) {
                Console.Write(a18 + ",");
            }

            Console.ReadKey();
        }
    }
}
