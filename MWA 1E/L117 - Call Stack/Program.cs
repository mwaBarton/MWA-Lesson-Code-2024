using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L117___Call_Stack
{
    internal class Program
    {
        static void SillySub(int number)
        {
            Console.WriteLine(number);
            SillySub(number + 1);
        }

        static void Main(string[] args)
        {
            SillySub(1);
        }
    }
}
