using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L149___Classes_and_Objects
{
    internal class Goose
    {
        public float height, wingspan;
        public bool canFloat;
        public string favouriteBread;

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

            Console.WriteLine("The goose is now h="+height+" and w="+wingspan);
        }
    }
}
