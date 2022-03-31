using System;
using System.Collections.Generic;
using System.Text;

namespace _31._03._2022_HomeWorkFromBashir_sTask.Models
{
    public static class MyExtensions
    {
        public static double Power (this int baseNumber, int expNumber)
        {
            
            double result = 1;
            bool sing = true;
            if (expNumber < 0)
            {
                sing = false;
                expNumber = expNumber * -1;
            }
            for (int i = 1; i <= expNumber; i++)
            {
                if (sing)
                    result = result * baseNumber;
                else
                    result /= baseNumber;
            }
            return result;
        }
    }
}
