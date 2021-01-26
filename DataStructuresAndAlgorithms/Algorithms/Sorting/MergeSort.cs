using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms.Sorting
{
	public static partial class Sort
	{
		public static int[] MergeSort(int[] numbers)
		{
			var length = numbers.Length;
			if (length == 1)
				return numbers;

			var leftSize = (length % 2 == 0) ? length / 2 : (length / 2) + 1;
			var rightArray = new int[length / 2];
			var leftArray = new int[leftSize];


			rightArray = Split(numbers, 0, length / 2);
			leftArray = Split(numbers, length / 2, leftSize);

			rightArray = MergeSort(rightArray);
			leftArray = MergeSort(leftArray);

			return MergeSortedArray(rightArray, leftArray);
		}

		private static int[] Split(int[] numbers, int startIndex, int size)
        {
			if (size <= 0)
				return null;
			var splitNumbers = new int[size];
            for (int i = 0; i < size; i++)
            {
				splitNumbers[i] = numbers[startIndex + i];
            }

			return splitNumbers;
        }

		public static int[] MergeSortedArray(int[] nums1, int[] nums2)
        {
			var size1 = nums1.Length;
			var size2 = nums2.Length;
			var size = size1 + size2;
			var newNumbers = new int[size];
			var lastIndex = size1-- + --size2;

			while(size1 >= 0 && size2 >= 0)
            {
				newNumbers[lastIndex--] = nums1[size1] > nums2[size2] ? nums1[size1--] : nums2[size2--];
            }

			if (size1 >= 0)
				while (size1 >= 0)
					newNumbers[lastIndex--] = nums1[size1--];
			else if (size2 >= 0)
				while (size2 >= 0)
					newNumbers[lastIndex--] = nums2[size2--];

			return newNumbers;
		}
	}
}
