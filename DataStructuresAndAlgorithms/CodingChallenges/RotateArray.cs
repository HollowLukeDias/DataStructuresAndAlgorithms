using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.CodingChallenges
{
    class RotateArray
    {
        public static int[] Rotate(int[] array, int steps)
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
    }
}
