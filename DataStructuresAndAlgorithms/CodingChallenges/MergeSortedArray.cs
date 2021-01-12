using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.CodingChallenges
{
    class MergeSortedArray
    {

        // O(N^2) - Horrible time complexity
        // O(N) - Space Complexity
        public static List<int> HorribleMerge(List<int> array1, List<int> array2)
        {
            if (array1.Count == 0 && array2.Count == 0) return null;
            if (array1.Count == 0) return array2;
            if (array2.Count == 0) return array1;


            var array3 = new List<int>();
            array3.AddRange(array1);
            array3.AddRange(array2);


            for (int i = 0; i < array3.Count; i++)
            {
                for (int j = i; j < array3.Count; j++)
                {
                    if (array3[i] > array3[j])
                    {
                        var temp = array3[i];
                        array3[i] = array3[j];
                        array3[j] = temp;
                    }
                }
            }

            return array3;
        }

        // O(N * log N) - Bad Time Complexity
        // O(N) - Fair Space Complexity
        // Cheated
        public static List<int> BadMerge(List<int> array1, List<int> array2)
        {
            if (array1.Count == 0 && array2.Count == 0) return null;
            if (array1.Count == 0) return array2;
            if (array2.Count == 0) return array1;


            var array3 = new List<int>();
            array3.AddRange(array1);
            array3.AddRange(array2);

            array3.Sort();
            return array3;
        }

    }
}
