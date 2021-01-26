using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.CodingChallenges
{
    class LongestCommonPrefix
    {
        public string Longest(string[] strs)
        {
            var j = 0;
            StringBuilder strBuilder = new StringBuilder();
            try
            {
                while (true)
                {
                    var checker = strs[0][j];
                    for (int i = 1; i < strs.Length; i++)
                    {
                        if (strs[i][j] != checker)
                            return strBuilder.ToString();
                    }
                    strBuilder.Append(strs[0][j]);
                    j++;
                }
            }
            catch
            {
                return strBuilder.ToString();
            }
        }
    }
}
