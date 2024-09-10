using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100___Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number;
            number = int.Parse(Console.ReadLine());

            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Hello" + name);
            Console.WriteLine("Welcome to my first C# program!");
            Console.WriteLine(number * 2 + 1);

            Console.ReadKey();
        }
    }
}
