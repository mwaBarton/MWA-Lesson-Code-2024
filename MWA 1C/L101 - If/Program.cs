using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L101___If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);

            if (name == "Matt")
            {
                Console.WriteLine("Welcome back!");
            }
            else if (name == "Ashton")
            {
                Console.WriteLine("You shall not pass!");
            }
            else
            {
                Console.WriteLine("Welcome!");
            }

            Console.Write("Enter a number between 1 and 10: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number <= 10)
            {
                Console.WriteLine("valid");
            }
            else if (number <= 0 || number > 10)
            {
                Console.WriteLine("invalid");
            }

            Console.ReadKey();
        }
    }
}
