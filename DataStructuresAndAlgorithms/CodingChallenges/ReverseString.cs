using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms 
{ 
    class ReverseString
    {
        public static string Reverse(string str)
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            return result;
        }
    }
}
