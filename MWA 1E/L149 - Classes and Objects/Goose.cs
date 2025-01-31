using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace L149___Classes_and_Objects
{
    internal class Goose
    {
        public float height, wingspan;
        public bool canFloat;
        public string favouriteBread;

        public void Initialise()
        {
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
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
