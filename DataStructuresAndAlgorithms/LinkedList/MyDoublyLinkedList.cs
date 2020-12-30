using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LinkedList
{
    class DoubleNode
    {
        public int Value;
        public DoubleNode Next;
        public DoubleNode Previous;

        public DoubleNode(int value)
        {
            Value = value;
        }
    }

    public class MyDoublyLinkedList : ILinkedList
    {
        private DoubleNode _head;
        private DoubleNode _tail;
        private int _size;

        public MyDoublyLinkedList(int value)
        {
            var firstNode = new DoubleNode(value);
            _head = firstNode;
            _tail = firstNode;
            _size = 1;
        }

        public void Append(int value)
        {
            var newNode = new DoubleNode(value);
            newNode.Previous = _tail;
            _tail.Next = newNode;
            _tail = newNode;
            _size++;
        }

        public void Prepend(int value)
        {
            var newNode = new DoubleNode(value);
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
            _size++;
        }

        public void Insert(int index, int value)
        {
            if (index == 0)
            {
                Prepend(value);
                return;
            }

            var newNode = new DoubleNode(value);
            var currentNode = GetNode(index);
            var prevNode = currentNode.Previous;

            newNode.Next = currentNode;
            newNode.Previous = prevNode;

            currentNode.Previous = newNode;
            prevNode.Next = newNode;

            _size++;
        }

        public void RemoveAt(int index)
        {
            var nodeToRemove = GetNode(index);
            var prevNode = nodeToRemove.Previous;
            var nextNode = nodeToRemove.Next;

            prevNode.Next = nextNode;
            nextNode.Previous = prevNode;

            _size--;
        }

        public int? Get(int index)
        {
            return GetNode(index).Value;
        }

        public List<int> GetAll()
        {
            var list = new List<int>();
            var currentNode = _head;

            for (int i = 0; i < _size; i++)
            {
                list.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }

            return list;
        }

        private DoubleNode GetNode(int index)
        {
            if (index >= _size) return null;
            var node = (index <= (_size / 2)) ? GetNodeOnFirstHalf(index) : GetNodeOnSecondHalf(index); // First or second half
            return node;
        }

        private DoubleNode GetNodeOnFirstHalf(int index)
        {
            var node = _head;
            for (int i = 0; i < index; i++)
                node = node.Next;

            return node;
        }

        private DoubleNode GetNodeOnSecondHalf(int index)
        {
            var node = _tail;
            for (int i = 0; i < index; i++)
                node = node.Previous;

            return node;
        }
    }
}
