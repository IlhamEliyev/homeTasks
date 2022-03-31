using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._2022_ClassWork.Models
{
    class Bicycle : Vehicle, IWheel
    {

        private string _pedalKind;
        private double _wheelThickness;

        public string PedalKind { get; set; }
        public double WheelThickness { get => _wheelThickness; set => _wheelThickness = value; }

        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{PedalKind} - {WheelThickness}");
        }
    }
}
