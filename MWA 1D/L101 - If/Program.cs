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

            if (name == "Matt")
            {
                Console.WriteLine("Welcome, back!");
            } 
            else if (name != "Aidan")
            {
                Console.WriteLine("You are not welcome here!");
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
