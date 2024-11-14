using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L124___Structures
{
    internal class Program
    {
        struct Dog
        {
            public int aggression;
            public int age;
            public string breed;
        }

        static Dog TrainDog(Dog d)
        {
            Dog result;

            result.aggression = d.aggression / 2;
            result.age = d.age + 1;
            result.breed = d.breed;

            return result;
        }

        static void Main(string[] args)
        {
            Dog dog;

            dog.breed = "Labradoodle";
            dog.age = -66;
            dog.aggression = 100;

            dog = TrainDog(dog);
            Console.WriteLine(dog.aggression);

            Console.ReadKey();
        }
    }
}
