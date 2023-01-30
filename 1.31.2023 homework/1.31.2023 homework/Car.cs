using System;
using System.Collections.Generic;
using System.Text;

namespace _1._31._2023_homework
{
    internal class Car : Vehicle
    {
        public Car(string Brand, string Model, double Millage, double FuelCapacity, double CurrentFuel) : base(Brand, Model, Millage)
        {
            this.CurrentFuel = CurrentFuel;
            this.FuelCapacity = FuelCapacity;
        }

        public double FuelCapacity;
        public double CurrentFuel;

        public void AddFuel(double Lt)
        {

            if (CurrentFuel + Lt <= FuelCapacity)
            {
                CurrentFuel += Lt;
            }

        }
    }
}
