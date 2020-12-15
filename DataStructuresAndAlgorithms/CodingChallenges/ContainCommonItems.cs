// Given 2 arrays, create a function that lets a user know (true or false) wheter these two arrays contain common items
// For exemple:
// array1 = ["a", "b", "c", "d", "x"]
// array2 = ["z", "y", "i"]
// should return false
// --------------------
// array1 = ["a", "b", "c", "d", "x"]
// array2 = ["z", "y", "x"]
// should return true


// To test in Main
// char[] str1 = new char[160000];
// char[] str2 = new char[160000];
//
// for (int i = 0; i < 160000; i++)
// {
//     str1[i] = 'h';
//     str2[i] = 'm';
// }
//
// var result = ContainCommonItems.CommonItemsHorrible(str1, str2);
// Console.WriteLine(result);
//
// var result2 = ContainCommonItems.CommonItemsFair(str1, str2);
// Console.WriteLine(result2);

using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class ContainCommonItems
    {
        // O(a * b) - Time Complexity (two different arrays) - Horrible
        // O(1)   - Space Complexity - Great
        public static (float seconds, bool result) CommonItemsHorrible(char[] firstArray, char[] secondArray)
        {
            var start = DateTime.Now;
            DateTime end;
            float seconds;
            foreach (char char1 in firstArray)
            {
                foreach (char char2 in secondArray)
                {
                    if (char1 == char2)
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

        // O(a + b) - Time Complexity - Good
        // O(n) - Space Complexity - Good
        public static (float second, bool result) CommonItemsFair(char[] firstArray, char[] secondArray)
        {
            var start = DateTime.Now;
            DateTime end;
            float seconds;
            HashSet<char> foundChars = new HashSet<char>();

            foreach(char char1 in firstArray)
            {
                foundChars.Add(char1);
            }

            foreach(char char2 in secondArray)
            {
                if (foundChars.Contains(char2)){
                    end = DateTime.Now;
                    seconds = (float) (end - start).TotalMilliseconds;
                    return (seconds, true);
                }
            }

            end = DateTime.Now;
            seconds = (float)(end - start).TotalMilliseconds;
            return (seconds, false);
        }
    }
}
