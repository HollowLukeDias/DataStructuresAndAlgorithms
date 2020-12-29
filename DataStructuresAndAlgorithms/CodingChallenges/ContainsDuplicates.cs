using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.CodingChallenges
{
    class ContainsDuplicates
    {

        // O(n^2) - Time Complexity - Bad
        // O(1)   - Space Complexity - Great
        // Nested Loops
        public static bool ContainsDuplicatesBad(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1;  j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // O(n) - Time Complexity - Good
        // O(n) - Space Complexity - Good
        // Hash
        public static bool ContainsDuplicateGood(int[] array)
        {
            var hash = new HashSet<int>();
            foreach (var number in array)
            {
                if (hash.Contains(number))
                    return true;

                hash.Add(number);
            }

            return false;
        }


        // O(N * Log N ) - Time Complexity - Fair
        // O(1)          - Space Complexity - Great
        //Sorting
        public static bool ContainsDuplicateFair(int[] array)
        {
            Array.Sort(array);

            for (int i = 0; i < array.Length - 1; i++)
                if (array[i] == array[i + 1]) return true;

            return false;
        }
    }
}
