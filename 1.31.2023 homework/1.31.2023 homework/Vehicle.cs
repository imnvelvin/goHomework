using System;
using System.Collections.Generic;
using System.Text;

namespace _1._31._2023_homework
{
    internal class Vehicle
    {
        public Vehicle(string Brand, string Model, double Millage)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Millage = Millage;
        }

        public string Brand;
        public string Model;
        public double Millage;
    }
}
