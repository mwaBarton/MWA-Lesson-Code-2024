using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L162___Recursion
{

    internal class Program
    {

        static string[] results = new string[101];

        static string f(int x) { 
            if (results[x] != "bleh")
            {
                //Console.Write(results[x]);
                return results[x];
            }
            else if (x > 0)
            {
                string s = "";
                s += f(x - 1);
                s += x;
                //Console.Write(x);
                s +=f(x - 1);
                //results[x] = s;
                return s;
            }
            else
            {
                return "";
            }
        } 

        static void Main(string[] args)
        {
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = "bleh";
            }

            f(28);
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
