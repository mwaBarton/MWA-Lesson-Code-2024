using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L144___2D_arrays
{
    internal class Program
    {
        static int[,] A2 = new int[10, 10];
        static int x = 0;
        static int y = 0;


        static void PrintGrid()
        {
            Console.Clear();
            for (int j = 0; j < A2.GetLength(1); j++)
            {
                for (int i = 0; i < A2.GetLength(0); i++)
                {
                    Console.Write(A2[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            A2[0,0] = 1;
            PrintGrid();

            while (true)
            {
                A2[x, y] = 0;
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                }
                A2[x, y] = 1;

                PrintGrid();
            }
        }
    }
}
