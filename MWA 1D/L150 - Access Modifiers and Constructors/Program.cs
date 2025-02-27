using System;
using System.Data.SqlTypes;

namespace L150___Access_Modifiers_and_Constructors
{
    public class Avocado
    {
        private bool ripe = true;
        public int nutritionValue;
        private int percentageRotten = 0;

        //Getter
        public bool IsRipe()
        {
            return ripe;
        }

        // Setter
        public void SetRipe(bool ripeValue)
        {
            if (ripeValue == false)
            {
                ripe = ripeValue;
            }
        }

        public void LeaveOnTheCounterForAWeek()
        {
            percentageRotten += 20;
            if (percentageRotten >= 100)
            {
                ripe = false;
                nutritionValue = 0;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Avocado avocado = new Avocado();

            avocado.nutritionValue = 62;

            avocado.LeaveOnTheCounterForAWeek();
            avocado.LeaveOnTheCounterForAWeek();
            avocado.LeaveOnTheCounterForAWeek();
            avocado.LeaveOnTheCounterForAWeek();
            avocado.LeaveOnTheCounterForAWeek();

            if (avocado.IsRipe())
            {
                Console.WriteLine("yum");
            }

        }
    }
}
