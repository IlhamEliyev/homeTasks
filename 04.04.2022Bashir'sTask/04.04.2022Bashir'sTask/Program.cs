using _04._04._2022Bashir_sTask.Models;
using System;

namespace _04._04._2022Bashir_sTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hilton = new Hotel("Hilton");
            Room rm = new Room("104", 14.5, 2);
            Room rm2 = new Room("105", 24.5, 4);
            Room rm3 = new Room("106", 34.5, 8);
            hilton.AddRoom(rm);
            Console.WriteLine(rm.ID);
            hilton.AddRoom(rm2);
            Console.WriteLine(rm2.ID);
            hilton.AddRoom(rm3);
            Console.WriteLine(rm3.ID);
            Console.WriteLine(rm);
            Console.WriteLine(rm2);
            Console.WriteLine(rm3);
            Console.WriteLine();
            Console.Write("Enter ID of the room you wish to reserve: ");
            int number = Convert.ToInt32(Console.ReadLine());
            hilton.Reserve(number);
            Console.WriteLine();
            Console.WriteLine(hilton[number - 1]);
            Console.ReadLine();
        }
    }
}
