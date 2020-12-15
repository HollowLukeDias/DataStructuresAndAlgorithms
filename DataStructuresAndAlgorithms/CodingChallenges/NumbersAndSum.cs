// Given an array containing numbers that can be positive or negative
// And another number that represents a sum called S
// Check wether or not there are numbers in the array that sum up to S
// Example:
// [1, 2, 3, 9] Sum = 8
// should return false
// --------------------
// [1, 2, 4, 4] Sum = 8
// should return true


//To use in the Main
//List<int> integers = new List<int>();
//
//for (int i = 1; i < 100000; i++)
//{
//    integers.Add(i);
//}
//
//var result = NumbersAndSum.NumbersAndSumHorrible(integers, 3);
//var result2 = NumbersAndSum.OrderedNumbersAndSumGood(integers, 0);
//var result3 = NumbersAndSum.UnorderedNumbersAndSumGood(integers, 0);
//Console.WriteLine(result + "  " + result2 + "  " + result3);

using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.CodingChallenges
{
    class NumbersAndSum
    {

        // O(n^2) - Time Complexity
        // O(1) - Space Complexity
        public static (float seconds, bool result) NumbersAndSumHorrible(List<int> numbers, int sum)
        {
            var start = DateTime.Now;
            DateTime end;
            float seconds;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j < numbers.Count - 1; j++)
                {
                    if ((i + j) == sum)
                    {
                        end = DateTime.Now;
                        seconds = (float)(end - start).TotalMilliseconds;
                        return (seconds, true);
                    }
                }
            }
            end = DateTime.Now;
            seconds = (float)(end - start).TotalMilliseconds;
            return (seconds, false);
        }

        // O(N) - Time Complexity
        // O(1) - Space Complexity
        public static (float seconds, bool result) OrderedNumbersAndSumGood(List<int> numbers, int sum)
        {
            var start = DateTime.Now;
            DateTime end;
            float seconds;
            int smallest = 0;
            int biggest = numbers.Count - 1;

            while (smallest < biggest)
            {
                var numbersSum = numbers[smallest] + numbers[biggest];
                if (numbersSum == sum)
                {
                    end = DateTime.Now;
                    seconds = (float)(end - start).TotalMilliseconds;
                    return (seconds, true);
                }

                if (numbersSum < sum) smallest++;
                if (numbersSum > sum) biggest--;

            }

            end = DateTime.Now;
            seconds = (float)(end - start).TotalMilliseconds;
            return (seconds, false);
        }

        // O(n) - Time Complexity
        // O(n) - Space Complexity
        public static (float seconds, bool result) UnorderedNumbersAndSumGood(List<int> numbers, int sum)
        {
            var start = DateTime.Now;
            DateTime end;
            float seconds;
            HashSet<int> hashedNumbers = new HashSet<int>(numbers.Count);

            foreach (var number in numbers)
            {
                if (hashedNumbers.Contains(number))
                {
                    end = DateTime.Now;
                    seconds = (float)(end - start).TotalMilliseconds;
                    return (seconds, true);
                }

                hashedNumbers.Add(sum - number);
            }

            end = DateTime.Now;
            seconds = (float)(end - start).TotalMilliseconds;
            return (seconds, false);
        }
    }
}
