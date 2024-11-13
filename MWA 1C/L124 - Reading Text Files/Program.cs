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
            string filename = "colours.txt";

            using (StreamReader sr = new StreamReader(filename))
            {
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();
                    if (line == "red" || line == "crimson")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine(line);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            string contents = File.ReadAllText(filename);
            Console.WriteLine(contents);

            Console.ReadKey();
        }
    }
}
