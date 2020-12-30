// Given an array, rotate the array to the right by k steps, where k is non-negative.
//
// Example 1:
//
// Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
// Output:[5,6,7,1,2,3,4]
// Explanation:
// rotate 1 steps to the right: [7,1,2,3,4,5,6]
// rotate 2 steps to the right: [6,7,1,2,3,4,5]
// rotate 3 steps to the right: [5,6,7,1,2,3,4]


using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.CodingChallenges
{
    class RotateArray
    {
        // O(a*b) - Time Complexity - Bad
        // O(1) - Space Complexity - Great
        public static int[] RotateSlow(int[] array, int steps)
        {
            var length = array.Length;
            var modSteps = steps % length;
            for (int i = 0; i < modSteps; i++)
            {
                var temp = array[length - 1];
                for (int j = length - 1; j > 0 ; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = temp;
            }
            return array;
        }

        // O(n) - Time Complexity - Good
        // O(n) - Space Complexity - Good
        public static int[] RotateFastLuke(int[] array, int steps)
        {
            var length = array.Length;
            var modSteps = steps % length;
            if (modSteps == 0)
                return array;

            var invertedArray = new int[length];
            var j = 0;
            for (int i = length - modSteps; i < length; i++)
            {
                invertedArray[j] = array[i];
                j++;
            }

            for (int i = 0; i < length - modSteps; i++)
            {
                invertedArray[j] = array[i];
                j++;
            }

            return invertedArray;
        }

        // O(n) - Time Complexity - Good
        // O(n) - Space Complexity - Bad
        public static int[] RotateExtraArray(int[] array, int steps)
        {
            var length = array.Length;

            var invertedArray = new int[length];

            // (i + steps) % length is where the number has to be for that ammount of steps
            for (int i = 0; i < length; i++)
            {
                invertedArray[(i + steps) % length] = array[i];
            }

            return invertedArray;
        }

        // O(n) - Time Complexity - Good
        // O(1) - Space Complexity - Great
        public static int[] RotateCyclicReplacement(int[] array, int steps)
        {
            var length = array.Length;
            var modSteps = steps % length;
            var count = 0;

            // Go step by step to understand
            // This for is here because maybe going from the first number is not possible to pass through every element
            // Algebra
            for (int start = 0; count < length; start++)
            {
                int current = start;
                int prev = array[start];
                do
                {
                    var next = (current + modSteps) % length;
                    var temp = array[next];
                    array[next] = prev;
                    prev = temp;
                    current = next;
                    count++;
                } while (start != current);
            }

            return array;
        }

        // O(n) - Time Complexity - Good
        // O(1) - Space Complexity - Great
        public static int[] RotateInvert(int[] array, int steps)
        {
            var length = array.Length;
            var modSteps = steps % length;
            Array.Reverse(array, 0, length);
            Array.Reverse(array, 0, modSteps);
            Array.Reverse(array, modSteps, length - modSteps);
            return array;
        }
    }
}
