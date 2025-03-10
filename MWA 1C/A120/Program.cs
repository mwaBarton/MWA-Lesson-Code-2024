using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A120
{
    internal class Program
    {
        // Print Grid
        static void PrintGrid(int[,] grid, int[] rowTotals, int highestRowNum, int highestColumnNum)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if ((i == highestRowNum) && (j == highestColumnNum)) Console.ForegroundColor = ConsoleColor.Yellow;
                    else if (i == highestRowNum) Console.ForegroundColor = ConsoleColor.Red;
                    else if (j == highestColumnNum) Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(grid[i, j]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("|");
                }
                if (i == highestRowNum) Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(rowTotals[i]);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        // Generating Grid
        static int[,] GenerateGrid(int width, int height)
        {
            int[,] nums = new int[height, width];
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

        // Calculating totals
        static int[] CalculateTotals(int[,] grid, ref int highestRowNum, ref int highestColumnNum)
        {
            int[] rowTotals = new int[grid.GetLength(0)];
            int highestRowTotal = 0;
            highestRowNum = -1;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                rowTotals[i] = 0;
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    rowTotals[i] += grid[i, j];
                }
                if (rowTotals[i] > highestRowTotal)
                {
                    highestRowTotal = rowTotals[i];
                    highestRowNum = i;
                }
            }

            int[] columnTotals = new int[grid.GetLength(1)];
            int highestColumnTotal = 0;
            highestColumnNum = -1;
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
                    highestColumnNum = j;
                }
            }

            return rowTotals;
        }

        static void Main(string[] args)
        {
            int[,] grid = GenerateGrid(5, 5);
            int highestRowNum = -1, highestColumnNum = -1;
            int[] rowTotals = CalculateTotals(grid, ref highestRowNum, ref highestColumnNum);

            PrintGrid(grid, rowTotals, highestRowNum, highestColumnNum);

            Console.ReadKey();
        }
    }
}
