using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L117___Call_stack_and__Lists
{
    internal class Program
    {
        static void SillySub(int num)
        {
            Console.WriteLine(num);
            SillySub(num + 1);
        }

        static void Main(string[] args)
        {
            SillySub(1);

            Console.ReadKey();
        }
    }
}
