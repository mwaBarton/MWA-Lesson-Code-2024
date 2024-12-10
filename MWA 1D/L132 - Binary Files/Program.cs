using System;
using System.Collections.Generic;
using System.IO;

namespace L132___Binary_Files
{
    internal class Program
    {
        struct Student
        {
            public int age;
            public string name;
        }

        static void WriteStudentToFile(Student s, string fileName)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
            {
                writer.Write(s.age);
                writer.Write(s.name);
            }
        }

        static Student ReadStudentFromFile(string fileName)
        {
            Student result = new Student();

            // TODO: Complete this function
        }

        static void WriteStudentsToFile(List<Student> students, string fileName)
        {
            // TODO: Complete this function
            // Hint: write the length of the list first
            // Then, write a function to read a list of students from a file
        }


        static void Main(string[] args)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("data.bin", FileMode.OpenOrCreate)))
            {
                writer.Write("Hats");
                writer.Write(14);
                writer.Write((int)ConsoleColor.Blue);
            }

            using (BinaryReader reader = new BinaryReader(File.Open("data.dat", FileMode.OpenOrCreate)))
            {
                Console.ForegroundColor = (ConsoleColor)reader.ReadInt32();
                string name = reader.ReadString();
                int num = reader.ReadInt32();


                Console.WriteLine($"There are {num} many {name}.");
            }

            Console.ReadKey();
        }
    }
}
