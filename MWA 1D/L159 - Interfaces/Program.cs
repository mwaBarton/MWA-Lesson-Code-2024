using System;
using System.Collections.Generic;

namespace L159___Interfaces
{
    public class Person : IComparable<Person>
    {
        public int age;
        public int numberOfLegs;

        public int CompareTo(Person other)
        {
            int thisScore, otherScore;

            thisScore = age * numberOfLegs;
            otherScore = other.age * other.numberOfLegs;

            if (thisScore < otherScore)
            {
                return -1;
            }
            else if (thisScore > otherScore) {
                return 1;
            } else
            {
                return 0;
            }
        }

        public static Person operator+(Person thisPerson, Person other)
        {
            return new Person() { age = Math.Max(thisPerson.age, other.age), numberOfLegs = thisPerson.numberOfLegs +  other.numberOfLegs };
        }

        public override string ToString()
        {
            return $"Person [age={age}, legs={numberOfLegs}]";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>() { 
                new Person() { age = 5, numberOfLegs = -6 }, 
                new Person()  { age = 17, numberOfLegs = 2 },
                new Person() { age = 2, numberOfLegs = 3 }
            };

            Person p = new Person() { numberOfLegs = 2, age = 22 };
            Person p2 = new Person() { numberOfLegs = 1, age = 50 };

            Person p3 = p + p + p2;
            Console.WriteLine(p3);


            foreach (Person person in list) {
                Console.WriteLine(person);
            }
            Console.WriteLine("\n\n\n");

            list.Sort();

            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}
