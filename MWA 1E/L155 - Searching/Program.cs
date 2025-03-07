using System;
using System.Linq;

namespace L155___Searching
{
    internal class Program
    {
        static int LinearSearch(int[] A, int toFind)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == toFind)
                {
                    return i;
                }
            }
            return -1;
        }

        static void BubbleSort(int[] A)
        {
            bool swapped = false;

            for (int i = 0; i < A.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        swapped = true;
                        A[j] = A[j] + A[j + 1];
                        A[j + 1] = A[j] - A[j + 1];
                        A[j] = A[j] - A[j + 1];
                    }
                }
                if (!swapped) break;
            }
        }

        static int BinarySearch(int[] A, int toFind)
        {
            int L = 0, H = A.Length - 1;

            while (L <= H) {
                int M = (L + H) / 2;
                if (A[M] == toFind)
                {
                    return M;
                }
                else if (A[M] < toFind)
                {
                    L = M + 1;
                }
                else if (A[M] > toFind) { 
                    H = M - 1;
                }
            }
            return -1;
        }

        static int[] RandomArray(int size)
        {
            int[] result = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                result[i] = random.Next(0, int.MaxValue);
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] nums = RandomArray(80000);

            Console.WriteLine(nums.Select(n => n.ToString()).Aggregate((a,b) => a + "," + b));

            DateTime start = DateTime.Now;
            Console.WriteLine(LinearSearch(nums, 3));
            DateTime end = DateTime.Now;
            Console.WriteLine((end - start).TotalMilliseconds + "ms");

            BubbleSort(nums);

            start = DateTime.Now;
            Console.WriteLine(BinarySearch(nums, 3));
            end = DateTime.Now;
            Console.WriteLine((end - start).TotalMilliseconds + "ms");

            Console.ReadKey();
               
        }
    }
}
