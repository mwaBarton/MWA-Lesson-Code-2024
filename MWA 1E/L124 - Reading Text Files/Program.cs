using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L124___Reading_Text_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileContents = File.ReadAllText("colours.txt");
            //Console.WriteLine(fileContents);
            Console.ReadKey();

            // The proper way
            using (StreamReader sr = new StreamReader("colours.txt"))
            {
                while (sr.EndOfStream == false) { 
                    string line = sr.ReadLine();
                    if (line == "red") Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(line);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            Console.ReadKey();
        }
    }
}
