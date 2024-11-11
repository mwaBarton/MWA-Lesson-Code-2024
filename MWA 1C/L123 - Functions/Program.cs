using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L123___Functions
{
    internal class Program
    {
        static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;

            if (result >= 0)
            {
                return result;
            } else
            {
                Console.WriteLine("You've unlocked teh secreets.");
                return 42;
            }
        }

        static void Main(string[] args)
        {
            int result = Multiply(21, -57);

            Console.WriteLine(result);

            Console.WriteLine(Multiply(3,4));
            Console.ReadKey();

            //List<List<int>> bigList = new List<List<int>>();
            //int count = 0;

            //while (true)
            //{
            //    count++;
            //    bigList.Add(new List<int>() { 1, 2, 3 });
            //}
        }
    }
}
