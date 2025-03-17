using System.Collections.Generic;

namespace L158
{
    public abstract class Consumable
    {
        protected bool consumed;
        protected int power;
        public Consumable(int inPower)
        {
            power = inPower;
            consumed = false;
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
            Potion p = new Potion(50);
            Snack s = new Snack(2, 50);

            List<Consumable> food = new List<Consumable>();
            food.Add(s);
            food.Add(p);

            foreach (Consumable consumable in food)
            {
                consumable.Consume();
            }
        }
    }
}
