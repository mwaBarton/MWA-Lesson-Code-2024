using System;

namespace L102___Types_and_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dNum;

            dNum = 6.0;

            dNum = 6;


            int number;

            number = 6;

            number = (int)Math.Round(4.5, MidpointRounding.AwayFromZero);

            Console.WriteLine(number);


            string s = "hello";
            char c = '*';
            c = s[0];

            s = "56";
            int num3 = int.Parse(s);

            s = "true";
            bool b = bool.Parse(s);

            b = (s == "Matt");

            s = "-4.5";
            double d = double.Parse(s);

            s = d.ToString();

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
