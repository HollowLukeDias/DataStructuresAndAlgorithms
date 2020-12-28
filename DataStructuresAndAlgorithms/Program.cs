using DataStructuresAndAlgorithms.CodingChallenges;
using DataStructuresAndAlgorithms.Hash;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main()
        {
            var hash = new MyHash(100);

            hash.Set("Lucas", 10291);
            Console.WriteLine(hash.Get("Lucas"));
        }
    }
}
