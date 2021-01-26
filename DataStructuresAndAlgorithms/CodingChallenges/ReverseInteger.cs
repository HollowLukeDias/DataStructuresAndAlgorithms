using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.CodingChallenges
{
    class ReverseInteger
    {

        // O(N) - Time Complexity
        // O(1) - Space Complexity
        public int Reverse(int x)
        {
            var xChars = x.ToString().ToCharArray();
            Array.Reverse(xChars);
            var reverseStringX = new string(xChars);
            try
            {
                var reverseX = int.Parse(reverseStringX);
                return reverseX;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
