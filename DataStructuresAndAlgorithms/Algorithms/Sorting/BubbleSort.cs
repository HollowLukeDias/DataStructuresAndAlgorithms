using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms.Sorting
{
    public static partial class Sort
    {

        public static int[] BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length ; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
