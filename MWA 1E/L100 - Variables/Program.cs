﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100___Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string word;

            word = Console.ReadLine();

            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Welcome to my first ever C# program.");
            Console.WriteLine(number * 2 + 1);
            Console.WriteLine(word);

            Console.ReadKey();
        }
    }
}
