using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L114___Built_in_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine();

            string s = "Hello World";

            //Console.WriteLine(Console.ReadLine());

            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s);

            Console.WriteLine(s.Length);
            //Console.WriteLine(Console.ReadLine().Length);

            char c = Console.ReadKey(true).KeyChar;
            if (c == 'a')
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("moved up");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("moved down");
                    break;
            }


            string s1 = "bananananananananan";

            Console.WriteLine(s1.IndexOf("nan"));

            foreach (char letter in s1)
            {
                int code = (int)letter;
                code = code - 42;
                char newLetter = (char)code;
                Console.Write(newLetter);
            }

            Console.ReadKey();
        }
    }
}
