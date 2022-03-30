using System;
using System.Collections.Generic;
using System.Text;

namespace _30._03._2022_HomeWorkBashir_sTask.Models
{
    class Square : Figure
    {


        private double _side;

        public double Side { get { return _side;  }
            set
            {
                if(value > 0)
                {
                    _side = value;
                }
            }
        }

        public Square(double side)
        {
            Side = side;
        }

        public override void CalcArea()
        {
            Console.WriteLine("Square");
        }
    }
}
