using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._2022_ClassWork.Models
{
    class Plane : Vehicle, IEngine, ITransmission
    {

        private double _wingLength;
        private int _horsePower;
        private double _tankSize;
        private double _currentOil;
        private string _fuelType;
        private string _transmissionKind;

        public double WingLength { get; set; }
        public int HorsePower { get { return _horsePower; } set { _horsePower = value; } }
        public double TankSize { get => _tankSize; set => _tankSize = value; }
        public double CurrentOil { get => _currentOil; set => _currentOil = value; }
        public string FuelType { get => _fuelType; set => _fuelType = value; }

        public string TransmissionKind { get => _transmissionKind; set => _transmissionKind = value; }

        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public double LeftFuelAmount()
        {
            return TankSize - CurrentOil;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{WingLength} - {HorsePower} - {TankSize} - {CurrentOil} - {FuelType} - {TransmissionKind}");
        }
    }
}
