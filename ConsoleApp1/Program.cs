using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            string insert = "y"; 
            
            while (insert.ToLower() == "y")
            {
                Car car = new Car();
                Console.WriteLine("Sportauto oder Normales Auto?");

                string carType = Console.ReadLine();
                if (carType.ToUpper().Equals("SPORTAUTO"))
                {
                    car = newSportsCar();
                }
                else if (carType.ToUpper().Equals("NORMALES AUTO"))
                {
                    car = newCar();
                }
                else
                {
                    Console.WriteLine("Eingabe war falsch!");
                    return;
                }

                cars.Add(car);
                Console.WriteLine("Noch ein Auto einfügen? (Y/N)");
                insert = Console.ReadLine();
            }

            foreach (Car car1 in cars)
            {
                Console.WriteLine(car1);
            }
        }

        private static Car newCar()
        {
            Car car = new Car();
            createCar(car);

            return car;
        }
        private static Car newSportsCar()
        {
            Sportscar car = new Sportscar();
            createCar(car);

            return car;
        }

        private static void createCar(Car car)
        {
            Console.WriteLine("Hersteller?");
            car.Manufacturer = Console.ReadLine();

            Console.WriteLine("Name?");
            car.Name = Console.ReadLine();

            Console.WriteLine("Baujahr?");
            int.TryParse(Console.ReadLine(), out var yearOfManufactor);
            car.YearOfManufactor = yearOfManufactor;

            Console.WriteLine("Farbe?");
            car.Color = Console.ReadLine();
        }
    }
}
