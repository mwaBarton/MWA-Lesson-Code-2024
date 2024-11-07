using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L121___ConsoleKeyAvailable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.WriteLine("HEllo");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("World");
            Console.WriteLine("Press any key to continue...");

            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
            Console.CursorVisible = true;
            Console.ReadKey();
            Console.CursorVisible = false;

            Console.Clear();

            Console.WriteLine("Welcome to my game");

            Console.ReadKey();
        }
    }
}
