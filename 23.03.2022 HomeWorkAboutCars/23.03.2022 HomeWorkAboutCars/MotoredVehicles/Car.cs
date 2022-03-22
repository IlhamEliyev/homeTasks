using System;
using System.Collections.Generic;
using System.Text;

namespace _23._03._2022_HomeWorkAboutCars.MotoredVehicles
{
    class Car : MotoredVehicles
    {
        public bool isOn;
        public Car(string make, string model, string productionYear) : base(make, model, productionYear)
        {

        }
        public void TurnOn()
        {
            Console.WriteLine("Avtomobil ishe dushdu.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Avtomobil sonduruldu.");
        }
        public void Go(double destination)
        {
            if (isOn == false)
            {
                TurnOn();
                if (destination * fuelUsedPerKm < fuelTankSize)
                {
                    Console.WriteLine(destination + " km məsafə qət edildi");
                }
                else
                {
                    Console.WriteLine("Kifayət qədər yanacaq yoxdur");
                    TurnOff();
                }
            }
        }
        public override void GetDetailedInfo()
        {
            base.GetDetailedInfo();
            Console.WriteLine("Fuel amount : " + fuelAmount);
        }

    }

}

