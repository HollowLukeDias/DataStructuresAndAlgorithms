using DataStructuresAndAlgorithms.CodingChallenges;
using DataStructuresAndAlgorithms.Hash;
using DataStructuresAndAlgorithms.LinkedList;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main()
        {
            var linked = new MyLinkedList(0);
            linked.Append(1);
            linked.Append(2);
            linked.Append(3);
            linked.Append(4);
            linked.Append(5);
            linked.Append(6);
            linked.Prepend(-1);
            linked.Prepend(-2);
            linked.Prepend(-3);
            linked.Prepend(-4);

            linked.Reverse();
            var list = linked.GetAll();
            foreach (var number in list)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }
    }
}
