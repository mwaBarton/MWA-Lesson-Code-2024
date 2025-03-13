using System;
using System.Collections.Generic;

namespace L157___Polymorphism
{
    public class Animal
    {
        public string name;
        public virtual string MakeNoise()
        {
            return "*generic animal noise*";
        }
    }

    public class Giraffe : Animal
    {
        public int numSpots;
        public override string MakeNoise()
        {
            return "neigh";
        }
    }

    public class CleverGirrafe : Giraffe
    {
        public override string MakeNoise()
        {
            string s = base.MakeNoise();
            return s + ", my name is " + name;
        }
    }

    public class Pig : Animal
    {
        public override string MakeNoise()
        {
            return "oink";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Giraffe());
            zoo.Add(new Pig());
            zoo.Add(new CleverGirrafe());
            zoo.Add(new Animal());

            foreach (Animal a in zoo)
            {
                Console.WriteLine(a.MakeNoise());
            }

            Console.ReadKey();
        }
    }
}
