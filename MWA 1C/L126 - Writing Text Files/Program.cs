using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L126___Writing_Text_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("animal.noises", "woof\r\nmoo\r\nbaaa\r\n");


            using (StreamWriter sw = new StreamWriter("animal.noises", true))
            {
                sw.WriteLine("meow");

                string line = " ";
                while (line != "")
                {
                    Console.Write("Enter next animal noise: ");
                    line = Console.ReadLine();

                    if (line != "")
                    {
                        sw.WriteLine(line);
                    }
                }
            }
        }
    }
}
