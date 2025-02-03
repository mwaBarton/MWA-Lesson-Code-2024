using System;

namespace L150___Access_Modifiers_and_Constructors
{
    internal class Goose
    {
        private float height, wingspan;
        private bool canFloat;
        private string favouriteBread;
        public Goose(float height, float wingspan, string favouriteBread)
        {
            this.height = height;
            this.wingspan = wingspan;
            this.canFloat = true;
            this.favouriteBread = favouriteBread;
        }

        public Goose(bool initialise)
        {
            if (initialise)
            {
                this.Initialise();
            }
        }

        //getter
        public string GetFavouriteBread()
        {
            return favouriteBread;
        }

        public void MakeBadChoices()
        {
            favouriteBread = "Poison bread";
        }

        private void Initialise()
        {
            while (height <= 0)
            {
                Console.Write("Enter height: ");
                height = float.Parse(Console.ReadLine());
            }
            Console.Write("Enter wingspan: ");
            wingspan = float.Parse(Console.ReadLine());
            Console.Write("Can the goose float? (Y/N) ");
            canFloat = (Console.ReadLine().ToUpper() == "Y");
            Console.Write("Enter favourite bread: ");
            favouriteBread = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"Goose [height={height},wingspan={wingspan},canFloat={canFloat},favouriteBread='{favouriteBread}']");
        }

        public void Grow(int yearsElapsed)
        {
            if (favouriteBread == "German Rye bread")
            {
                height += yearsElapsed * 1000;
                wingspan -= yearsElapsed;
            }
            else if (favouriteBread == "Poison bread")
            {
                canFloat = false;
                Console.WriteLine("You fed the goose poison. Nice.");
            }
            else
            {
                height += yearsElapsed;
                wingspan += yearsElapsed;
            }

            Print();
        }
    }
}
