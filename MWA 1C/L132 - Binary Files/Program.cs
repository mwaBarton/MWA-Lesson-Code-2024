using System;
using System.Collections.Generic;
using System.IO;

namespace L132___Binary_Files
{
    internal class Program
    {

        struct Lesson
        {
            public string room, teacherName;
            public int numOfStudents;
        }

        static void WriteLessonToFile(string filePath, Lesson lesson)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate)))
            {
                writer.Write(lesson.room);
                writer.Write(lesson.teacherName);
                writer.Write(lesson.numOfStudents);
            }
        }

        static Lesson ReadLessonFromFile(string filePath)
        {
            Lesson lesson = new Lesson();

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.OpenOrCreate)))
            {
                lesson.room = reader.ReadString();
                lesson.teacherName = reader.ReadString();
                lesson.numOfStudents = reader.ReadInt32();
            }

            return lesson;
        }

        static void WriteLessonsToFile(string filePath, List<Lesson> lessons)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate)))
            {
                writer.Write(lessons.Count);
                foreach (Lesson lesson in lessons)
                {
                    writer.Write(lesson.room);
                    writer.Write(lesson.teacherName);
                    writer.Write(lesson.numOfStudents);
                }
            }
        }

        static void Main(string[] args)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("data.dat", FileMode.OpenOrCreate)))
            {
                writer.Write("Blue");
                writer.Write(6);
                writer.Write((int)ConsoleColor.Cyan);
                writer.Write(true);
            }
            using (BinaryReader reader = new BinaryReader(File.Open("data.dat", FileMode.OpenOrCreate)))
            {
                string s = reader.ReadString();
                int n = reader.ReadInt32();
                Console.ForegroundColor = (ConsoleColor)reader.ReadInt32();
                bool b = reader.ReadBoolean();

                Console.WriteLine($"{s}, {n}, {b}");
            }

            Lesson lesson = new Lesson()
            {
                room = "N11",
                teacherName = "Matt",
                numOfStudents = 21
            };

            WriteLessonToFile("lessons.bin", lesson);

            Lesson result = ReadLessonFromFile("lessons.bin");

            Console.WriteLine($"{result.teacherName} ({result.room}): {result.numOfStudents}");

            Console.ReadKey();
        }
    }
}
