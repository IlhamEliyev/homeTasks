using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Zehmet olmasa ededi daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isReminder = false;
            for (int i = 2; i*i <= n; i++)
            {
                if (n % i == 0)
                {
                    isReminder = true;
                } 
            }
            if (isReminder) Console.WriteLine("Eded murekkebdir");
            else Console.WriteLine("Eded sadedir");
            ////Task 2
            //Console.WriteLine("Zehmet olmasa ededi daxil edin: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int count = 1;
            //if (n < 0) n = n * (-1);
            //while (n > 9)
            //{
            //    n = n / 10;
            //    count++;
            //}
            //Console.WriteLine(count);


                ////Task 3
                //Console.WriteLine("Zehmet olmasa ededi daxil edin: ");
                //int num = Convert.ToInt32(Console.ReadLine());
                //int changeNum = num;
                //int reminder;
                //int sum = 0;

                //while (changeNum > 0)
                //{
                //    reminder = changeNum % 10;
                //    sum = sum * 10 + reminder;
                //    changeNum = changeNum / 10;
                //}
                //if (sum == num)
                //{
                //    Console.WriteLine("Palindromdur");
                //}
                //else
                //{
                //    Console.WriteLine("Polindrom deyil");
                //}

        }
    }
}
