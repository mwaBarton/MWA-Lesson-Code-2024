using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L133___Exceptions
{
    internal class Program
    {
        static char GradeCalculator(int scorePercentage)
        {
            if (scorePercentage >= 80)
            {
                return 'A';
            }
            else if (scorePercentage >= 70)
            {
                return 'B';
            }
            else if (scorePercentage >= 60)
            {
                return 'C';
            }
            else if (scorePercentage >= 50)
            {
                return 'D';
            }
            else if (scorePercentage >= 0)
            {
                return 'U';
            }

            return 'X';
        }

        static void Main(string[] args)
        {
            
            try
            {
                int score;
                Console.Write("What's your percentage: ");

                score = int.Parse(Console.ReadLine());

                Console.WriteLine("Your grade was " + GradeCalculator(score));
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error occurred.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
            Console.ReadKey();
        }

    }
}
