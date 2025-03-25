using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L162___Recursion
{
    internal class Program
    {
        static string[] results = new string[101];

        static string Fun(int x)
        {
            if (results[x] != null)
            {
                //Console.Write(results[x]);
                return results[x];
            }
            else if (x > 0)
            {
                string s = "";
                s += Fun(x - 1);
                //Console.Write(x);
                s += x;
                s += Fun(x - 1);
                //results[x] = s;
                //Console.WriteLine($"Saved x={x}, length={s.Length}");
                return s;
            }

            return "";
        }

        static void Main(string[] args)
        {
            Fun(28);
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
