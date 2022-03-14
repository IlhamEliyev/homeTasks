using System;

namespace AboutOverloadMethod_HomeTask_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateArea(2,5,5));
        }

        static int CalculateArea(int r)
        {
            int area = 3 * r * r;
            return area;
        }
        static int CalculateArea(int a, int b)
        {
            int area = a * b;
            return area;
        }

        static int CalculateArea(int a, int b, int c)

        {
            int area = 2 * (a * b + a * c + b * c);
            return area;
        }
    }
}
