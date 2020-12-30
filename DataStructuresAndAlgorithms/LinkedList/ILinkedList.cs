using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LinkedList
{
    interface ILinkedList
    {
        void Append(int value);
        void Prepend(int value);
        void Insert(int index, int value);
        void RemoveAt(int index);
        int? Get(int index);
        List<int> GetAll();
    }
}
