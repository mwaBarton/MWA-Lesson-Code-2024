using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L116___Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int x = int.Parse(s);


            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}
