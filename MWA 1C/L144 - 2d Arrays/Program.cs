using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L144___2d_Arrays
{
    internal class Program
    {

        static void PrintGrid(char[,] grid)
        {
            Console.Clear();
            for (int i = 0; i < grid.GetLength(1); i++)
            {
                for (int j = 0; j < grid.GetLength(0); j++)
                {
                    if (grid[j, i] == 'P') Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(grid[j, i]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine();
            }
        }

        static void CoolProgramUsing2DArrays()
        {
            char[,] grid = new char[20, 20];
            int x = 0, y = 0;

            for (int i = 0; i < grid.GetLength(1); i++)
            {
                for (int j = 0; j < grid.GetLength(0); j++)
                {
                    grid[j, i] = '.';
                }
            }
            grid[x, y] = 'P';

            PrintGrid(grid);

            while (true)
            {
                ConsoleKey keypressed = Console.ReadKey(true).Key;
                grid[x, y] = '.';

                switch (keypressed)
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

                grid[x, y] = 'P';

                PrintGrid(grid);
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            numbers[5] = 6;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }

            Console.WriteLine("\n\n");

            // 2D Array
            int[,] grid = new int[7,3];

            grid[0, 0] = 5;
            grid[0, 1] = 6;
            grid[0, 2] = 7;

            for (int i = 0; i < grid.GetLength(1); i++)
            {
                for (int j = 0; j < grid.GetLength(0); j++)
                {
                    Console.Write(grid[j,i]);
                }
                Console.WriteLine();
            }

            CoolProgramUsing2DArrays();

            Console.ReadKey();
        }
    }
}
