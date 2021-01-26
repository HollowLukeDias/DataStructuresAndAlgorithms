using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms.Sorting
{
    public static partial class Sort
    {

        public static int[] SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var smallestIndex = i;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[smallestIndex]> numbers[j])
                        smallestIndex = j;
                }
                var temp = numbers[i];
                numbers[i] = numbers[smallestIndex];
                numbers[smallestIndex] = temp;
            }
            return numbers;
        }
    }
}
