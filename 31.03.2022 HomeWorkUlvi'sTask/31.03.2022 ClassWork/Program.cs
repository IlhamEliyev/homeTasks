using _31._03._2022_ClassWork.Models;
using System;

namespace _31._03._2022_ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int models = 1;
            while (models > 0 && models < 4)
            {
                Console.WriteLine("1.Car 2.Bicycle 3. Plane 0. Quiting...");
                models = Convert.ToInt32(Console.ReadLine());
                switch (models)
                {
                    case 1:
                        Console.WriteLine("Enter the Car's Drive Path : ");
                        int drivePath = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Car's Drive Time : ");
                        int driveTime = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Car's Door Count : ");
                        int doorCount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Car's Wincode : ");
                        string winCode = Console.ReadLine();
                        Console.WriteLine("Enter the Car's Horse Power: ");
                        int horsePower = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Car's Tank Size : ");
                        double tankSize = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Car's Current oil : ");
                        double currentOil = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Car's Fuel Type : ");
                        string fuelType = Console.ReadLine();
                        Console.WriteLine("Enter the Car's Wheel Thickness : ");
                        double wheelThickness = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Car's Transmission Kind : ");
                        string transmissionKind = Console.ReadLine();
                        Car car = new Car();
                        car.DoorCount = doorCount;
                        car.WinCode = winCode;
                        car.HorsePower = horsePower;
                        car.TankSize = tankSize;
                        car.CurrentOil = currentOil;
                        car.FuelType = fuelType;
                        car.WheelThickness = wheelThickness;
                        car.TransmissionKind = transmissionKind;
                        car.DrivePath = drivePath;
                        car.DriveTime = driveTime;
                        Console.WriteLine("Speed = " + car.AverageSpeed());
                        Console.WriteLine("Left Fuel Amount = " + car.LeftFuelAmount());
                        car.ShowInfo();

                        break;
                    case 2:
                        Console.WriteLine("Enter the Bicycle's Drive Path : ");
                        int drivePath1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Bicycle's Drive Time : ");
                        int driveTime1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Bicycle's Pedal Kind : ");
                        string pedalKind = Console.ReadLine();
                        Console.WriteLine("Enter the Bicycle's Wheel Thickness : ");
                        double wheelThickness1 = Convert.ToDouble(Console.ReadLine());
                        Bicycle bicycle = new Bicycle();
                        bicycle.PedalKind = pedalKind;
                        bicycle.WheelThickness = wheelThickness1;
                        bicycle.DriveTime = driveTime1;
                        bicycle.DrivePath = drivePath1;
                        Console.WriteLine("Speed = " + bicycle.AverageSpeed());
                        bicycle.ShowInfo();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Plane's Drive Path : ");
                        int drivePath2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Plane's Drive Time : ");
                        int driveTime2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Plane's wing length : ");
                        double wingLength = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Plane's Horse Power: ");
                        int horsePower1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Plane's Tank Size : ");
                        double tankSize1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Plane's Current oil : ");
                        double currentOil1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Plane's Fuel Type : ");
                        string fuelType1 = Console.ReadLine();
                        Console.WriteLine("Enter the Plane's Wheel Thickness : ");
                        string transmissionKind1 = Console.ReadLine();
                        Plane plane = new Plane();
                        plane.WingLength = wingLength;
                        plane.HorsePower = horsePower1;
                        plane.TankSize = tankSize1;
                        plane.CurrentOil = currentOil1;
                        plane.FuelType = fuelType1;
                        plane.TransmissionKind = transmissionKind1;
                        plane.DriveTime = driveTime2;
                        plane.DrivePath = drivePath2;
                        Console.WriteLine("Speed = " + plane.AverageSpeed());
                        Console.WriteLine("Left Fuel Amount = " + plane.LeftFuelAmount());
                        plane.ShowInfo();
                        break;
                    default:
                        Console.WriteLine("Quiting...");
                        break;
                }
            }
        }
    }
}
