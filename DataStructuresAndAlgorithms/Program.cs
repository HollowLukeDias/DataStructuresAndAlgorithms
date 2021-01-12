using DataStructuresAndAlgorithms.CodingChallenges;
using DataStructuresAndAlgorithms.Hash;
using DataStructuresAndAlgorithms.LinkedList;
using DataStructuresAndAlgorithms.Tree;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main()
        {
            var tree = new MyBinaryTree();
            tree.Insert(50);
            tree.Insert(25);
            tree.Insert(75);
            tree.Insert(30);
            tree.Insert(80);
            tree.Insert(20);
            tree.Insert(70);
            tree.Insert(35);
            tree.Insert(85);
            tree.Insert(15);
            tree.Insert(65);
            tree.Insert(72);
            tree.Insert(79);
            tree.Insert(29);
            tree.Insert(21);



            BTreePrinter.Print(tree.Root);
        }
    }
}
