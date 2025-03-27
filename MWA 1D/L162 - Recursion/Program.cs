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
        static string F(int x)
        {
            if (x == 0) return "";
            if (results[x] != null) return results[x];

            string result = F(x - 1) + x + F(x - 1);
            results[x] = result;
            return result;
        }


        static void F(int x, StringBuilder sb)
        {
            if (x == 0) return;

            F(x - 1, sb);
            sb.Append(x);
            F(x - 1, sb);
        }

        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            F(25, new StringBuilder());
            s.Stop();
            //Console.WriteLine(r);

            Console.WriteLine(s.ElapsedMilliseconds + "ms");
            Console.ReadKey();
        }
    }
}
