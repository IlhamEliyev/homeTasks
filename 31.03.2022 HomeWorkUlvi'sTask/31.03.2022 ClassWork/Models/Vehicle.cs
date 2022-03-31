using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._2022_ClassWork.Models
{
    abstract class Vehicle
    {
        private double _driveTime;
        private double _drivePath;


        public double DriveTime{ get { return _driveTime;  }
            set
            {
                if(value > 0)
                {
                    _driveTime = value;
                }
            }
        }

        public double DrivePath
        {
            get { return _drivePath; }
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                }
            }
        }


        public abstract double AverageSpeed();
        

        public abstract void ShowInfo();
        
    }
}
