using _30._03._2022_HomeWorkUlvi_sTask.Models;
using System;

namespace _30._03._2022_HomeWorkUlvi_sTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Employee 2.Student");
            int models = Convert.ToInt32(Console.ReadLine());
            switch (models)
            {
                case 1:
                    Console.WriteLine("Enter the employee name : ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the employee surname : ");
                    string surname = Console.ReadLine();
                    Console.WriteLine("Enter the employee age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the employee salaryOfHour: ");
                    int salaryOfHour = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the employee workingHour: ");
                    int workingHour = Convert.ToInt32(Console.ReadLine());
                    Employee employee = new Employee(name, surname, age, salaryOfHour, workingHour);
                    Console.WriteLine("Calculate Salary " + employee.CalculateSalary()); 
                    break;
                case 2:
                    Console.WriteLine("Enter the student name : ");
                    string name1 = Console.ReadLine();
                    Console.WriteLine("Enter the student surname : ");
                    string surname1 = Console.ReadLine();
                    Console.WriteLine("Enter the stundent age: ");
                    int age1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the employee iqRank: ");
                    int iqRank = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the employee languageRank: ");
                    int languageRank = Convert.ToInt32(Console.ReadLine());
                    Student student = new Student(name1, surname1, age1, iqRank, languageRank);
                    student.ExamResults();
                    break;
                default:
                    Console.WriteLine("Quiting...");
                    break;
            }
        }
    }
}
