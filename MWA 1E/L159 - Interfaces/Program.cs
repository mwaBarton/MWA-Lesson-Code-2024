using System;
using System.Collections.Generic;
using System.Linq;

namespace L159___Interfaces
{
    public interface ITasty
    {
        bool IsSalty();
        void Eat();
        void Season(List<string> seasoning);
    }

    public interface IConsumable
    {
        void Eat();
        bool IsConsumed();
    }

    public class Hamburger : ITasty, IConsumable, IComparable<Hamburger>
    {
        private List<string> ingredients = new List<string>();
        private bool consumed = false;

        public int CompareTo(Hamburger other)
        {
            int salt = ingredients.Count(i => i == "salt");
            int otherSalt = other.ingredients.Count(i => i == "salt");

            if (salt > otherSalt) { return 1; }
            else if (salt < otherSalt) { return -1; }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "[" + ingredients.Count(i => i == "salt") + " salts.]";
        }

        public void Eat()
        {
            consumed = true;
            Console.WriteLine("yum. ,yum.");
        }

        public bool IsConsumed()
        {
            return consumed;
        }

        public bool IsSalty()
        {
            return ingredients.Contains("salt");
        }

        public void Season(List<string> seasoning)
        {
            ingredients.AddRange(seasoning);
        }
    }





    internal class Program
    {
        static void EatFood(IConsumable food)
        {
            food.Eat();
        }

        static void AddManySaltsToFood(ITasty food, int numOfSalts)
        {
            List<string> salts = new List<string>();
            for (int i = 0; i < numOfSalts; i++)
            {
                salts.Add("salt");
            }
            food.Season(salts);
        }

        static void Main(string[] args)
        {
            Hamburger food = new Hamburger();

            AddManySaltsToFood(food, 400);
            Hamburger ham2 = new Hamburger();
            AddManySaltsToFood(ham2, 200);
            Hamburger ham3 = new Hamburger();
            AddManySaltsToFood(ham3, 300);
            food.Eat();

            List<Hamburger> hamburgerList = new List<Hamburger> { food, ham2, ham3 };
            foreach (Hamburger h in hamburgerList)
            {
                Console.WriteLine(h);
            }
            Console.WriteLine("\n\n");
            hamburgerList.Sort();

            foreach (Hamburger h in hamburgerList)
            {
                Console.WriteLine(h);
            }


            Console.ReadKey();
        }
    }
}
