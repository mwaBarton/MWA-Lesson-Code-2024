using System;

namespace L133___Exceptions
{
    internal class Program
    {
        static char GradeCalculator(int scorePercentage)
        {
            if (scorePercentage < 0 || scorePercentage > 100)
            {
                throw new ArgumentException("Score Percentage must be between 0 and 100.");
            }
            else if (scorePercentage >= 80)
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

            return 'X';
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
                catch (ArgumentException error)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: " + error.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Enter an integer.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }


            try
            {
                // Code...

                // If (bad thing happens)
                    throw new ArgumentException();
                // End if

                // Code...
            }
            catch (ArgumentException ex)
            {
                // Handle the exception
            }



            Console.WriteLine("Goodbye.");


            Console.ReadKey();
        }

    }
}
