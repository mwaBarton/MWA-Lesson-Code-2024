using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L157___Polymorphism
{
    public class Animal
    {
        public int weight;
        public virtual string MakeNoise()
        {
            return "*generic animal noise*";
        }
    }

    public class Cat : Animal
    {
        public override string MakeNoise()
        {
            return base.MakeNoise() + "Meow.";
        }
    }

    public class CleverCat : Cat
    {
        public override string MakeNoise()
        {
            return base.MakeNoise() + "Greetings.";
        }
    }

    public class Pigeon : Animal
    {
        public int breadEaten;
        public override string MakeNoise()
        {
            return "Coo.";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            //Console.WriteLine(a.MakeNoise());
            CleverCat cat = new CleverCat();
            //Console.WriteLine(cat.MakeNoise());
            Pigeon pigeon = new Pigeon();
            //Console.WriteLine(pigeon.MakeNoise());


            List<Animal> animals = new List<Animal>();
            animals.Add(a);
            animals.Add(cat);
            animals.Add(pigeon);

            Animal geoff = new Pigeon();
            geoff.weight = 6;
            Console.WriteLine(geoff.MakeNoise());

            animals.Add(geoff);

            Pigeon geoffThePigeon = (Pigeon)geoff;
            geoffThePigeon.breadEaten = 10;
            geoffThePigeon.weight = 5;
            Console.WriteLine(geoffThePigeon.MakeNoise());

            foreach (Animal animal in animals)
            {
                //Console.WriteLine(animal.MakeNoise());
            }

            Console.ReadKey();
        }
    }
}
