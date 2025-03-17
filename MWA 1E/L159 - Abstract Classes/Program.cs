using System;
using System.Collections.Generic;

namespace L159___Abstract_Classes
{
    public abstract class Consumable
    {
        protected bool consumed;
        protected int power;
        public Consumable(int inPower)
        {
            consumed = false;
            power = inPower;
        }
        public abstract void Consume();
        public bool IsConsumed() => consumed;
    }

    public class Potion : Consumable
    {
        public Potion(int inPower) : base(inPower) { }
        public override void Consume()
        {
            consumed = true;
        }
    }

    public class Snack : Consumable
    {
        protected int portionsLeft;
        public Snack(int portions, int inPower) : base(inPower)
        {
            portionsLeft = portions;
        }
        public override void Consume()
        {
            portionsLeft--;
            if (portionsLeft == 0) consumed = true;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Consumable> list = new List<Consumable>() { 
                new Potion(50),
                new Snack(2, 50)
            };

            bool done = false;
            while (!done) {
                done = true;
                foreach (Consumable consumable in list)
                {
                    if (consumable.IsConsumed())
                    {
                        Console.WriteLine("already consumed");
                    }
                    else
                    {
                        consumable.Consume();
                        done = false;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
