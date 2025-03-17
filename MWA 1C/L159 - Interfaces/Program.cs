using System;
using System.Collections.Generic;

namespace L159___Interfaces
{
    public interface IRoadVehicle
    {
        bool Drive(int distance);
        void OpenDoor();
        int GetNumberOfWarningLightsOn();
    }

    public interface IFlyingVehicle
    {
        bool Fly(int distance);
        void OpenDoor();
    }

    public class Car : IRoadVehicle, IFlyingVehicle, IComparable<Car>
    {
        public int mileage = 0;
        private List<string> warningLightsOn = new List<string>();

        public override string ToString()
        {
            return $"[m: {mileage}, numWarningLights: {GetNumberOfWarningLightsOn()}]";
        }

        public int CompareTo(Car other)
        {
            if (warningLightsOn.Count > other.warningLightsOn.Count)
            {
                return 1;
            }
            else if (warningLightsOn.Count < other.warningLightsOn.Count)
            {
                return -1;
            }
            else
            {
                if (mileage > other.mileage)
                {
                    return 1;
                }
                else if (mileage < other.mileage)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public bool Drive(int distance)
        {
            if (warningLightsOn.Contains("Door open"))
            {
                return false;
            }

            mileage += distance;

            if (mileage > 100000)
            {
                warningLightsOn.Add("Toooo far.");
                return false;
            }
            return true;
        }

        public bool Fly(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                warningLightsOn.Add("You cannot actually fly a car, you idiot.");
            }
            return false;
        }

        public int GetNumberOfWarningLightsOn()
        {
            return warningLightsOn.Count;
        }

        public void OpenDoor()
        {
            warningLightsOn.Add("Door open");
        }

        public static Car operator+(Car car, Car other)
        {
            Car result = new Car();
            result.mileage = car.mileage + other.mileage;
            result.warningLightsOn.AddRange(car.warningLightsOn);
            result.warningLightsOn.AddRange(other.warningLightsOn);
            return result;
        }
    }

    internal class Program
    {
        static void FlyVehicle(IFlyingVehicle vehicle)
        {
            vehicle.Fly(1);
        }

        static void Main(string[] args)
        {
            Car vehicle = new Car();

            vehicle.Drive(180000);
            vehicle.OpenDoor();
            vehicle.OpenDoor();
            vehicle.OpenDoor();
            vehicle.OpenDoor();
            vehicle.OpenDoor();
            vehicle.OpenDoor();
            vehicle.Fly(80000);

            Car v2 = new Car();
            v2.Drive(1);

            Car v3 = new Car();
            v3.OpenDoor();

            Car v4 = new Car();
            v4.Drive(50000);
            v4.OpenDoor();

            Car v5 = vehicle + v2 + v3 + v4;

            List<Car> cars = new List<Car>() { vehicle, v2, v3, vehicle, v4, v5 };
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
            
            Console.WriteLine("\n\n");
            cars.Sort();
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }


            //Console.WriteLine(vehicle.GetNumberOfWarningLightsOn());
            Console.ReadKey();
        }
    }
}
