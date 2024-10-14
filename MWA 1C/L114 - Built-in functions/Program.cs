using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace L114___Built_in_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.ReadLine();
            string s = "I'm bored of this";
            //Console.WriteLine(Console.ReadLine());

            Console.WriteLine(s[3]);

            Console.WriteLine(s.Length);

            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s);

            char c = Console.ReadKey(true).KeyChar;

            Console.WriteLine(c.ToString().ToUpper());

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("moved up");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("moved down");
                    break;
            }

            string s1 = "matthew";

            int index = s1.IndexOf("oo");

            if (index == -1)
            {
                Console.WriteLine($"'oo' not found in {s1}");
            } else
            {
                Console.WriteLine($"'oo' found at position {index}");
            }
            Console.WriteLine(index);

            s1 = "matthew";
            string s2 = "extension";

            Console.WriteLine(string.Compare(s2, s2));

            string s3 = "branch";
            foreach (char letter in s3)
            {
                int code = (int)letter;
                code = code - 32;
                Console.Write((char)code);
            }


            Console.ReadKey();
        }
    }
}
