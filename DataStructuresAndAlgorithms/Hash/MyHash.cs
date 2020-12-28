using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Hash
{
    public class MyHash
    {
        public static int Hash(string key, int length)
        {
            var hash = 0;
            var helperNumber = 0;

            if (key.Length == 1)
                return key[0] % length;

            foreach (var letter in key)
            {
                hash = (hash + letter * helperNumber) % length;
                helperNumber++;
            }

            return hash;
        }
    }
}
