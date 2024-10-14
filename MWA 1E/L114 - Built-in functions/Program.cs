using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L114___Built_in_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";

            Console.WriteLine(s.Length);

            s.ToUpper();

            string upper = s.ToUpper();
            Console.WriteLine(upper);
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

            string userWord = "morning";

            int index = userWord.IndexOf("eve");

            if (index != -1)
            {
                Console.WriteLine($"We found 'eve' at position {index}");
            } else
            {
                Console.WriteLine("We could not find 'eve'");
            }

            string newString = "computer";

            foreach (char letter in newString)
            {
                int code = (int)letter;
                code = code - 32;
                char newLetter = (char)code;

                Console.WriteLine(newLetter);
            }

            // Comparing strings

            string s1 = "Aadvark";
            string s2 = "Able";

            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s2, s1));
            Console.WriteLine(string.Compare(s2, s2));

            Console.ReadKey();
        }
    }
}
