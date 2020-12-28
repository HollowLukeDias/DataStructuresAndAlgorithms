using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.CodingChallenges
{
    public class FirstRepeating
    {

        // O(n^2) - Time Complexity - Bad
        // O(1)   - Space Complexity - Great
        public static int? FirstRepeatingItemBad(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count - 1; i++)
            {
                for (int j = i + 1; j < numberList.Count; j++)
                {
                    if (numberList[i] == numberList[j])
                    {
                        return numberList[i];
                    }
                }
            }

            return null;
        }


        // O(n) - Time Complexity - Good
        // O(n) - Space Complexity - Good
        public static int? FirstRepeatingItemGood(List<int> numbersList)
        {
            var hash = new HashSet<int>();

            foreach (var number in numbersList)
            {
                if (hash.Contains(number))
                    return number;

                hash.Add(number);
            }

            return null;
        }
    }
}
