using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms.Recursion
{
    class Factorial
    {
        public static long RecursiveFactorial(long number)
        {
            if (number == 2)
            {
                return 2;
            }
            return number * RecursiveFactorial(number) ;
        }

        public static long IterativeFactorial(long number)
        {
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
