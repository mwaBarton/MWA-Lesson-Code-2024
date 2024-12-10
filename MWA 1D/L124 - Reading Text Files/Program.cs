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
            using (StreamReader reader = new StreamReader("names.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }

            using (StreamReader reader = new StreamReader("names.txt"))
            {
                while (reader.EndOfStream)
                {

                }
            }


            string filename = "colours.txt";

            using (StreamReader sr = new StreamReader(filename))
            {
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();
                    if (line == "blue")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    //Console.WriteLine(line);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }

            string contents = File.ReadAllText(filename);
            Console.WriteLine(contents);

            Console.ReadKey();
        }
    }
}
