using System;

namespace L133___Exceptions
{
    internal class Program
    {
        static char GradeCalculator(int scorePercentage)
        {
            if (scorePercentage < 0 || scorePercentage > 100)
            {
                throw new ArgumentException("ERROR: You need to type in an integer between 0 and 100. Please try again.");
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
            else if (scorePercentage >= 0)
            {
                return 'U';
            }
            else
            {
                return 'X';
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
                    Console.WriteLine("ERROR: You need to type in an integer. Please try again.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (ArgumentException e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Unexpected error occurred" + e.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    success = true;
                }
            }

            Console.WriteLine("Goodbye.");

            Console.ReadKey();

        }
    }
}
