using System;
using System.Collections.Generic;
using System.Text;

namespace Neqliyat_Sistemi.Models
{
    internal class Car : Vehicle
    {
        private double _fuelCapacity;
        private double _fuel;
        public double FuelConsumptionPer100Km { get; set; }
        public double FuelCapacity
        {
            get { return _fuelCapacity; }
            set
            {
                if (value > 0)
                    _fuelCapacity = value;
                else
                    Console.WriteLine("Benzin tutumu 0 dan boyuk olmalidir");
            }
        }
        public double Fuel
        {
            get { return _fuel; }
            set
            {
                if (value > 0 && value <= FuelCapacity)
                    _fuel = value;
                else
                    Console.WriteLine("Benzin 0 dan boyuk olmalidir ve Benzin benzin tutumundan kicikdir ve ya beraberolmalidir");
            }
        }

        public Car(string brand, string model, int year, double fuelCapacity, double fuel, double fuelConsumptionPer100Km) : base(brand, model, year)
        {
            FuelCapacity = fuelCapacity;
            Fuel = fuel;
            FuelConsumptionPer100Km = fuelConsumptionPer100Km;
        }

        public void Refuel(double liters)
        {
            if (Fuel + liters <= FuelCapacity)
            {
                FuelCapacity += liters;
            }
            else
            {
                Console.WriteLine("Benzin tutumu asilir");
            }
        }
    }
}
