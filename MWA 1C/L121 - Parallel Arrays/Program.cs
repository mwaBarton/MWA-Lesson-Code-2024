using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L121___Parallel_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.WriteLine("It was a dark and stormy night...");

            System.Threading.Thread.Sleep(2500);

            Console.WriteLine("...and the rain came down in torrents!");
            Console.WriteLine("Press any key to continue...");

            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
            Console.CursorVisible = true;
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Welcome to my game.");

            Console.ReadKey();
        }
    }
}
