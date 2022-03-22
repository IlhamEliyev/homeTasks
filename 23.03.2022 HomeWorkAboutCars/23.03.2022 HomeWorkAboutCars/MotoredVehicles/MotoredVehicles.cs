using System;
using System.Collections.Generic;
using System.Text;

namespace _23._03._2022_HomeWorkAboutCars.MotoredVehicles
{
    class MotoredVehicles
    {
        public string make;
        public string model;
        public string productionYear;
        public double motorSize;
        public double fuelTankSize;
        public double fuelAmount;
        public double fuelUsedPerKm;
        public string color;
        public int transmission;
        public int horsePower;
        public int passengerCount;

        public MotoredVehicles()
        {

        }
        public MotoredVehicles(string make, string model, string productionYear)
        {
            this.make = make;
            this.model = model;
            this.productionYear = productionYear;
        }
        public void GetInfo()
        {
            Console.WriteLine("Bilgiler verilir");
        }
        public virtual void GetDetailedInfo()
        {
            Console.WriteLine("Detalli bilgiler verilir");
        }
        
        


    }
}
