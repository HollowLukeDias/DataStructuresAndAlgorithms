using DataStructuresAndAlgorithms.CodingChallenges;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main()
        {
            var list = new MyList();

            list.Push(1);
            list.Push(2);
            list.Delete(0);
            Console.WriteLine(list.Get(0) + "  " + list.Get(1));
        }
    }
}
