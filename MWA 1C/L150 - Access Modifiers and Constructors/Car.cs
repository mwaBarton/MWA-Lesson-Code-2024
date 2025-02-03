using System;

namespace L150___Access_Modifiers_and_Constructors
{
    internal class Car
    {
        public string colour;
        private int price;
        private bool priceSet = false;

        public Car(int price)
        {
            this.price = price;
        }


        public void SetPrice(int p)
        {
            if (!priceSet)
            {
                if (p > 0)
                {
                    price = p;
                    priceSet = true;
                }
            }
        }

        public void Drive(int distance)
        {
            
            price = price - distance;
            Console.WriteLine(price);
        }
    }
}
