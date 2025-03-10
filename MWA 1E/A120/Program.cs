using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A120
{
    internal class Program
    {
        static void PrintGrid(int[,] grid, int highestTotalRowIndex, int highestColumnTotalIndex, int[] totals)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (i == highestTotalRowIndex && j == highestColumnTotalIndex)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else if (i == highestTotalRowIndex)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (j == highestColumnTotalIndex)
                        Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.Write($"{grid[i, j]}");

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("|");
                }
                if (i == highestTotalRowIndex)
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(totals[i]);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("\n\n\n");
        }

        static int[] CalculateTotals(int[,] grid, ref int highestTotalRowIndex, ref int highestColumnTotalIndex)
        {
            int highestTotal = 0;
            int[] totals = new int[grid.GetLength(0)];
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                totals[i] = 0;
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    totals[i] += grid[i, j];
                }

                if (totals[i] > highestTotal)
                {
                    highestTotal = totals[i];
                    highestTotalRowIndex = i;
                }
            }

            int[] columnTotals = new int[grid.GetLength(1)];
            int highestColumnTotal = 0;
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                columnTotals[j] = 0;
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    columnTotals[i] += grid[i, j];
                }

                if (columnTotals[j] > highestColumnTotal)
                {
                    highestColumnTotal = columnTotals[j];
                    highestColumnTotalIndex = j;
                }
            }

            return totals;
        }

        static int[,] GenerateGrid(int size1, int size2)
        {
            int[,] nums = new int[size1, size2];
            Random rnd = new Random();

            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = rnd.Next(10, 100);
                }
            }

            return nums;
        }

        static void Main(string[] args)
        {
            int[,] nums = GenerateGrid(5, 5);

            int highestRow = -1, highestColumn = -1;
            int[] totals = CalculateTotals(nums, ref highestRow, ref highestColumn);

            PrintGrid(nums, highestRow, highestColumn, totals);

            Console.ReadKey();
        }
    }
}
