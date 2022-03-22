using System;
using _23._03._2022_HomeWorkAboutCars.MotoredVehicles;

namespace _23._03._2022_HomeWorkAboutCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Cars, 2. Motorcycle, 3. Boat");
            int motoredVehicles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the make : ");
            string make = Console.ReadLine();
            Console.WriteLine("Enter the model : ");
            string model = Console.ReadLine();
            Console.WriteLine("Enter the productionYear : ");
            string productionYear = Console.ReadLine();
            Console.WriteLine("Enter the motor size : ");
            double motorSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the fuel tank size : ");
            double fuelTankSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the fuel amount : ");
            double fuelAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the fuel used per km : ");
            double fuelUsedPerKm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Color : ");
            string color = Console.ReadLine();
            Console.WriteLine("Enter the transmission : ");
            int transmission = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the horse power : ");
            int horsePower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the passenger count : ");
            int passengerCount = Convert.ToInt32(Console.ReadLine());
            switch (motoredVehicles)
            {
                case 1:
                    Car car = new Car(make, model, productionYear);
                    car.motorSize = motorSize;
                    car.fuelTankSize = fuelTankSize;
                    car.fuelAmount = fuelAmount;
                    car.fuelUsedPerKm = fuelUsedPerKm;
                    car.color = color;
                    car.horsePower = horsePower;
                    car.passengerCount = passengerCount;
                    car.transmission = transmission;
                    Console.WriteLine(" Masinin markasi : " + car.make + " Masinin Modeli : " + car.model + " Masinin istehsal ili : "
                        + car.productionYear + " Matorunun hecmi" + car.motorSize + " Bakinin hecmi: "
                        + car.fuelTankSize + " Benzinin qiymeti: " + car.fuelAmount + " Masin bir kilometre nece litr benzin istifade edir:"
                        + car.fuelUsedPerKm + " Masinin rengi : " + car.color + " Masinin skoroslorarinin sayi: "
                        + car.transmission + " Masinin sernisin sayi: " + car.passengerCount + " Masinin at gucu : " + car.horsePower);
                    Console.WriteLine("1. Go 2. Getinfo 3. GetDetailedInfo");
                    int models = Convert.ToInt32(Console.ReadLine());

                    switch (models)
                    {
                        case 1:
                            Console.WriteLine("Please enter the destination");
                            double destination = Convert.ToInt32(Console.ReadLine());
                            car.Go(destination);
                            break;
                        case 2:
                            car.GetInfo();
                            break;
                        case 3:
                            car.GetDetailedInfo();
                            break;
                        default:
                            Console.WriteLine("1 2 ve ya 3 u secin !!!");
                            break;
                    }
                    break;
                case 2:
                    Motorcycle motorcycle = new Motorcycle();
                    break;
                case 3:
                    Boat boat = new Boat();
                    break;
                default:
                    Console.WriteLine("1 2 ve ya 3 u secin !!!");
                    break;
            }

        }
    }
}
