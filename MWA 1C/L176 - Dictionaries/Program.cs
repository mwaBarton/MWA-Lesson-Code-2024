using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L176___Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            foreach (string word in words) {
                if (wordCounts.ContainsKey(word)) { 
                    wordCounts[word]++;
                } else
                {
                    wordCounts.Add(word, 1);
                }
            }

            foreach (KeyValuePair<string, int> pair in wordCounts)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }

            Console.ReadKey();
        }
    }
}
