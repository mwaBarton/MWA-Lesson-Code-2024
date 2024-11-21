using System;
using System.IO;

namespace L126___Writing_Text_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // The 'easy' way
            File.WriteAllText("animal.noises", "moo\r\nmeow\r\noink\r\nwoof\r\nbaa\r\neeor\r\ngrr\r\n");


            // The proper way
            using (StreamWriter sw = new StreamWriter("animal.noises", true))
            {
                sw.WriteLine("rarr");
                sw.WriteLine("bubble");

                string line = " ";
                while (line != "")
                {
                    Console.Write("Enter a new animal noise: ");
                    line = Console.ReadLine();

                    if (line != "")
                    {
                        sw.WriteLine(line);
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
