using System;
using System.Collections.Generic;
using System.IO;

namespace L132___Binary_Files
{
    internal class Program
    {
        struct Lesson
        {
            public string teacherName, room;
            public int numberOfStudents;
        }

        static void WriteLessonToFile(Lesson lesson, string filename)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
            {
                writer.Write(lesson.teacherName);
                writer.Write(lesson.room);
                writer.Write(lesson.numberOfStudents);
            }
        }

        static Lesson ReadLessonFromFile(string filename) {
            Lesson lesson = new Lesson();

            // TODO
        }

        static void WriteLessonsToFile(List<Lesson> lessons, string filename) { 
            //TODO
            //Hint: Write length of the list as an integer first
        }

        static void Main(string[] args)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("data.bin", FileMode.OpenOrCreate)))
            {
                writer.Write("Red");
                writer.Write((int)ConsoleColor.Red);
                writer.Write(true);
                writer.Write(65);
            }


            using (BinaryReader reader = new BinaryReader(File.Open("data.bin", FileMode.OpenOrCreate)))
            {
                // This breaks because reading a different format

                string s = reader.ReadString();
                Console.ForegroundColor = (ConsoleColor)reader.ReadInt32();
                int i = reader.ReadInt32();

                bool b = reader.ReadBoolean();


                Console.WriteLine($"{s} {b} {i}");
            }

            Console.ReadKey();
        }
    }
}
