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
            var integers1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var integers2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var integers3 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var integers4 = new int[] { 1, 2, 3, 4, 5 };
            //integers1 = RotateArray.Rotate(integers1, 3);
            //foreach (var integer in integers1)
            //{
            //    Console.Write(integer + ", ");
            //}
            //Console.WriteLine();
            //integers2 = RotateArray.RotateSlow(integers2, 35);
            //foreach (var integer in integers2)
            //{
            //    Console.Write(integer + ", ");
            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------------------");
            //Console.WriteLine();

            integers3 = RotateArray.RotateFast(integers3, 3);
            foreach (var integer in integers3)
            {
                Console.Write(integer + ", ");
            }
        }
    }
}
