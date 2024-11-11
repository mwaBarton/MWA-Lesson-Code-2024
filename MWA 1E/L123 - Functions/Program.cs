using System;

namespace L123___Functions
{
    internal class Program
    {
        static int Add(int num1, int num2)
        {
            if (num1 < 0 || num2 < 0) {
                return 42;
            }

            int num3 = num1 + num2;
            return num3;
        }


        static void Main(string[] args)
        {
            int result;

            result = Add(83, 52);

            Console.WriteLine(result);

            Console.WriteLine(Add(-1, 30));
            Console.ReadKey();

            //List<List<int>> bigList = new List<List<int>>();

            //int count = 0;
            //while (true)
            //{
            //    count++;
            //    //Console.WriteLine(count);
            //    bigList.Add(new List<int>() { 1, 2, 3 });
            //}
        }
    }
}
