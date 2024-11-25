using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L127___Writing_Text_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The proper way (for cool people)

            using (StreamWriter writer = new StreamWriter("names.txt", true))
            {
                for (int i = 0; i < 10; i++)
                {
                    //writer.WriteLine(Console.ReadLine());
                }
            }


            // The "easy"
            File.WriteAllText("names2.txt", "name1\r\nname2\r\nname3");
        }
    }
}
