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
            int number;
            int num2;

            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum: " + (number + num2));
            Console.WriteLine("Product: " + (number * num2));

            Console.ReadKey();
        }
    }
}
