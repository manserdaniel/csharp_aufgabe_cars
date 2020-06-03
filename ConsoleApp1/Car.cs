using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        public CarType CarType = CarType.NORMALESAUTO;
        public String Manufacturer { get; set; }
        public String Name { get; set; }
        public int YearOfManufactor { get; set; }
        public String Color { get; set; }

        public Car(CarType carType)
        {
            this.CarType = carType;
        }

        public Car()
        {

        }

        public override string ToString()
        {
            return $"{CarType} {Manufacturer} {Name} {YearOfManufactor} {Color}";
        }
    }
}
