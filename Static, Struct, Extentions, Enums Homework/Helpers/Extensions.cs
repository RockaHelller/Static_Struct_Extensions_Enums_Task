using System;
using System.Collections.Generic;
using System.Text;

namespace Static__Struct__Extentions__Enums_Homework.Helpers
{
    public static class Extensions
    {

        public static double GetFactorial(this double a)
        {
            double sum = 1;

            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
                return sum;
        }
    }
}
