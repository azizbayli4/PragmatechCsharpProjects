using System;

namespace TaskAtLesson_05._11._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Color = "Blue",
                Brand = "BMW",
                Millage = 120,
                FuelForOneKm = 2
            };
            car.ShowInfo();
            car.Drive();
            Console.WriteLine("--------*********************--------");
            Bicycle bicycle = new Bicycle();
            bicycle.Drive();
        }
    }
    #region Vehicle
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Millage { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(string color, string brand, double millage)
        {
            this.Color = color;
            this.Brand = brand;
            this.Millage = millage;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Vehicle brand is {Brand} " +
                $"\nVehicle color is {Color} " +
                $"\nMillage is {Millage}");
        }

        public abstract void Drive();
    }

    class Car : Vehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelForOneKm { get; set; }

        public Car()
        {

        }
        public Car(string color, string brand, double millage, double capacity, double currentFuel, double fuelForOneKm) : base(color, brand, millage)
        {
            this.FuelCapacity = capacity;
            this.CurrentFuel = currentFuel;
            this.FuelForOneKm = fuelForOneKm;
        }

        public override void Drive()
        {
            Console.WriteLine("How many 'km' you wanna go?");
            double dist = Convert.ToDouble(Console.ReadLine());
            if (FuelForOneKm * CurrentFuel >= dist)
            {
                Console.WriteLine($"Fuel is enough to drive this distance {dist}");
                CurrentFuel -= dist * FuelForOneKm;
                Millage += dist;
                Console.WriteLine(Millage);
                Console.WriteLine(CurrentFuel);
            }
            else
            {
                Console.WriteLine($"Fuel is enough to drive this distance {dist}");
            }
        }

    }

    class Bicycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("How many 'km' you wanna go?");
            double dist = Convert.ToDouble(Console.ReadLine());
            if (dist > 0)
            {
                Millage += dist;
                Console.WriteLine($"You went {Millage} millage by bicycle");
            }
        }
    }
    #endregion
}
