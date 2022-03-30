using System;
using System.Collections.Generic;
using System.Text;

namespace _30._03._2022_HomeWorkUlvi_sTask.Models
{
    class Employee : Person
    {

        private double _salaryOfHour;
        private int _workingHour;
        private int _age;

        public double SalaryOfHour
        {
            get { return _salaryOfHour; }
            set
            {
                if (value > 0)
                {
                    _salaryOfHour = value;
                }
            }
        }

        public int WorkingHour
        {
            get { return _workingHour; }
            set
            {
                if (value > 0 && value <= 240)
                {
                    _workingHour = value;
                }
            }
        }

        public override int Age
        {
            get { return _age; }
            set
            {
                if (value >= 18)
                {
                    _age = value;
                }
            }
        }

        public Employee(string name, string surname, int age, double salaryOfHour, int workingHour) : base(name,surname)
        {
            Age = age;
            WorkingHour = workingHour;
            SalaryOfHour = salaryOfHour;
        }

        public double CalculateSalary()
        {
            double result = WorkingHour * SalaryOfHour;
            if (result > 250)
            {
                return result;
            }
            return 0;
        }
    }
}
