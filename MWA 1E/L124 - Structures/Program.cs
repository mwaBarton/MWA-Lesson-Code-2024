using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L124___Structures
{
    internal class Program
    {
        struct Student
        {
            public int age;
            public string name;
            public bool isFirstYear;
        }

        static void Main(string[] args)
        {
            Student firstStudent;
            Student secondStudent;

            firstStudent.name = "My name David itself";
            firstStudent.age = 16;
            firstStudent.isFirstYear = true;

            secondStudent.name = "Jacob";
            secondStudent.age = 17;
            secondStudent.isFirstYear = true;

            Console.WriteLine($"{firstStudent.name}: Age={firstStudent.age}, Y1={firstStudent.isFirstYear}");
            Console.WriteLine($"{secondStudent.name}: Age={secondStudent.age}, Y1={secondStudent.isFirstYear}");

            Console.ReadKey();
        }
    }
}
