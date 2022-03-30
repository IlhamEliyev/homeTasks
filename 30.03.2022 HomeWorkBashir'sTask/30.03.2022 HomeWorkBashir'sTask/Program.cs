using _30._03._2022_HomeWorkBashir_sTask.Models;
using System;

namespace _30._03._2022_HomeWorkBashir_sTask
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int models = 1;
            while (models > 0 && models <=2)
            {
                Console.WriteLine("1. Square 2.Rectangular 0.Quit");
                models = Convert.ToInt32(Console.ReadLine());
                switch (models)
                {
                    case 1:
                        Console.WriteLine("Please enter the square side");
                        double side = Convert.ToDouble(Console.ReadLine());
                        Square square = new Square(side);
                        square.CalcArea();
                        break;
                        case 2:
                        Console.WriteLine("Please enter the square width");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the square length");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Rectangular rectangular = new Rectangular(width,length);
                        rectangular.CalcArea();
                        break;
                    default:
                        Console.WriteLine("Quiting...");
                        break;
                }
            }
        }
    }
}
