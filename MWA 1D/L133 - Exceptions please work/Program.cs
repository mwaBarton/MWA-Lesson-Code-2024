using System;

namespace L133___Exceptions_please_work
{
    internal class Program
    {
        static char GradeCalculator(int scorePercentage)
        {
            if (scorePercentage < 0 || scorePercentage > 100)
            {
                throw new ArgumentException("Score must be between 0 and 100.");
            }

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
            else
            {
                return 'U';
            }
        }

        static void Main(string[] args)
        {
            bool success = false;
            while (!success)
            {
                try
                {
                    int score;
                    Console.Write("What's your percentage: ");
                    score = int.Parse(Console.ReadLine());
                    Console.WriteLine("Your grade was " + GradeCalculator(score));
                    success = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: You must enter an integer");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (ArgumentException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: " + e.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            }

            Console.WriteLine("bye.");

            Console.ReadKey();
        }
    }
}
