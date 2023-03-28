using System;
using System.Collections.Generic;

namespace Laba10
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public bool IsClean { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving...");
        }
    }

    public class Garage
    {
        public List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }

    }
    
        public class Washer
        {
            public void Wash(Car car)
            {
                car.IsClean = true;
                Console.WriteLine($"Washing {car.Color} {car.Make} {car.Model}...");
            }
        }

    delegate void CarWashDelegate(Car car);

    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car
            {
                Make = "Toyota",
                Model = "Corolla",
                Color = "Red",
                Year = 2015,
                IsClean = false
            };

            var car2 = new Car
            {
                Make = "Honda",
                Model = "Civic",
                Color = "Blue",
                Year = 2020,
                IsClean = false
            };
            var car3 = new Car
            {
                Make = "Lada",
                Model = "Shit",
                Color = "White",
                Year = 1983,
                IsClean = false
            };

            var garage = new Garage();
            garage.AddCar(car1);
            garage.AddCar(car2);

            CarWashDelegate washer = new Washer().Wash;
            washer(garage.cars[0]);
            washer(garage.cars[1]);


            //garage.WashAllCars(washer);

            Console.WriteLine($"Car 1 is clean: {car1.IsClean}");
            Console.WriteLine($"Car 2 is clean: {car2.IsClean}");
            Console.WriteLine($"Car 3 is clean: {car3.IsClean}");
        }
    }
}
