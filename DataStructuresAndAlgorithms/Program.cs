using DataStructuresAndAlgorithms.CodingChallenges;
using DataStructuresAndAlgorithms.Hash;
using DataStructuresAndAlgorithms.LinkedList;
using DataStructuresAndAlgorithms.Tree;
using DataStructuresAndAlgorithms.Algorithms.Recursion;
using System;
using System.Collections.Generic;
using DataStructuresAndAlgorithms.Algorithms.Sorting;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main()
        {
            var numbers = new int[] { 1, 4, 6, 12, 58, 13, 5, 3, -10, 159, 1020, 1200, 1019, 1199 };
            numbers = Sort.MergeSort(numbers);
            //var nums1 = new int[] { 1, 4, 7, 9, 10, 110, 150, 190, 215, 220 };
            //var nums2 = new int[] { 3, 5, 8, 15 };
            //var numbers = Sort.MergeSortedArray(nums1, nums2);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
