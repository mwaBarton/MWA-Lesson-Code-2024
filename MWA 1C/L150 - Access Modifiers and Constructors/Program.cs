using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L150___Access_Modifiers_and_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car(10);

            mycar.SetPrice(-19);
            mycar.SetPrice(10);
            mycar.SetPrice(15);
            mycar.colour = "Blue";
            mycar.Drive(4);
            
            Console.ReadKey();
        }
    }
}
