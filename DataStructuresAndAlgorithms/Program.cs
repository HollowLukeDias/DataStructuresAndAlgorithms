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
            var hash = new MyHashTable(2);

            hash.Set("Lucas", 10291);
            hash.Set("Jenn", 10000000);
            hash.Set("Sephiroph", 0);
            hash.Set("Cloud", 29);
            hash.Set("Aerith", 27);
            Console.WriteLine(hash.Get("Lucas"));
            Console.WriteLine(hash.Get("Jenn"));
            Console.WriteLine(hash.Get("Sephiroph"));
            Console.WriteLine(hash.Get("Cloud"));
            Console.WriteLine(hash.Get("Aerith"));



        }
    }
}
