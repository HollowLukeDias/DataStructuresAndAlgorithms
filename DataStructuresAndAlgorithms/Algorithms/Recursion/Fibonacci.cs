using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms.Recursion
{
    class Fibonacci
    {
        public static long RecursiveFibonacci(long number)
        {
            if (number < 2)
            {
                return number;
            } 
            return RecursiveFibonacci(number - 1) + RecursiveFibonacci(number - 2);
        }
    }
}
