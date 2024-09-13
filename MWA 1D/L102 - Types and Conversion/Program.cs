using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L102___Types_and_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = 6;
            num = (int)Math.Round(0.5, MidpointRounding.AwayFromZero);

            Console.WriteLine(num);

            double dNum;
            dNum = 4.5;
            dNum = 6;


            string s = "Matt";
            char c = 'q';
            c = s[2];
            Console.WriteLine(c);

            bool b = (s == "Matt");
            Console.WriteLine(b);

            int num2 = int.Parse(s);

            bool b2 = bool.Parse("False");

            s = b2.ToString();

            Console.ReadKey();
        }
    }
}
