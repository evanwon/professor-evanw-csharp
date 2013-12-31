using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExample
{
    class CarBuilder
    {
        private Car Car { get; set; }

        public static CarBuilder DefaultBuilder()
        {
            return new CarBuilder();
        }

        public CarBuilder()
        {
            Car = new Car();
            Car.Color = "Black";
            Car.Horsepower = 230;
            Car.Make = "Subaru";
            Car.Model = "Impreza WRX";
        }

        public Car Build()
        {
            return Car;
        }

        public CarBuilder Fast()
        {
            Car.Horsepower = 1000;

            return this;
        }

        public CarBuilder Blue()
        {
            Car.Color = "Blue";

            return this;
        }

        public CarBuilder ToyotaPrius()
        {
            Car.Make = "Toyota";
            Car.Model = "Prius";

            return this;
        }
    }
}
