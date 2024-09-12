using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L102___Data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = (int)4.5;

            double number = 4;

            Console.WriteLine(Math.Round(12.5));
            Console.WriteLine(Math.Round(13.5, MidpointRounding.AwayFromZero));

            Console.ReadKey();
        }
    }
}
