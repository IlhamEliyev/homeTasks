using _05._04._2022CurrencyTask.Models;
using System;

namespace _05._04._2022CurrencyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            USD usdV = new USD(300);

            AZN aznV = new AZN(150);

            Euro euro = new Euro(100);

            AZN azn1 = euro;

            Console.WriteLine(azn1 > euro);

        }
    }
}






