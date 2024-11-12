using System;

namespace L123___Functions
{
    internal class Program
    {
        static string AlternatingCapitals(string phrase)
        {
            string result = "";
            bool capital = false;
            foreach (char letter in phrase)
            {
                if (capital)
                {
                    result += letter.ToString().ToUpper();
                }
                else
                {
                    result += letter.ToString().ToLower();
                }

                if ("qwertyuiopasdfghjklzxcvbnm".Contains(letter.ToString().ToLower()))
                {
                    capital = !capital; 
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter phrase: ");
            string input = Console.ReadLine();
            string result = AlternatingCapitals(input);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
