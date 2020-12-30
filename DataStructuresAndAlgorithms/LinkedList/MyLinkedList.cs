using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LinkedList
{
    class Node
    {
        public int Data { get; set; }
        public Node NextNode { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }
    public class MyLinkedList : ILinkedList
    {
        private Node _head;
        private Node _tail;
        public int Size;

        public MyLinkedList(int data)
        {
            var newNode = new Node(data);
            _head = newNode;
            _tail = newNode;
            Size = 1;
        }

        public void Append(int data)
        {
            var newNode = new Node(data);
            _tail.NextNode = newNode;
            _tail = newNode;
            Size++;
        }

        public void Prepend(int data)
        {
            var newNode = new Node(data);
            var temp = _head;
            _head = newNode;
            newNode.NextNode = temp;
            Size++;
        }

        public void Insert(int index, int data)
        {
            var newNode = new Node(data);
            if (index == 0)
            {
                Prepend(data);
                return;
            }

            var prevNode = GetNode(index - 1);
            var currentNode = GetNode(index);
            prevNode.NextNode = newNode;
            newNode.NextNode = currentNode;
            Size++;
        }

        public void RemoveAt(int index)
        {
            var prevNode = GetNode(index - 1);
            var nextNode = GetNode(index + 1);
            prevNode.NextNode = nextNode;
            Size--;
        }

        public int? Get(int index)
        {
            var currentNode = _head;
            for (int i = 0; i < index ; i++)
            {
                if (currentNode.NextNode == null)
                    return null;

                currentNode = currentNode.NextNode;

            }
            return currentNode.Data;
        }

        private Node GetNode(int index)
        {
            if (index == 0)
                return _head;

            var currentNode = _head;
            for (int i = 0; i < index; i++)
                currentNode = currentNode.NextNode;

            return currentNode;
        }

        public List<int> GetAll()
        {
            var list = new List<int>();
            var currentNode = _head;
            while(currentNode.NextNode != null)
            {
                list.Add(currentNode.Data);
                currentNode = currentNode.NextNode;
            }
            list.Add(currentNode.Data);
            return list;
        }


        // Draw the node connections in a paper
        // Then try to think only of the pointers
        // Basically, you are reversing the pointers of two nodes and then going to the next two nodes to reverse them afterwards
        public void Reverse()
        {
            if (Size == 1)
                return;

            var first = _head;
            var second = _head.NextNode;

            while (second != null)
            {
                var temp = second.NextNode;
                second.NextNode = first;
                first = second;
                second = temp;
            }
            _head.NextNode = null;
            _head = first;

        }
    }
}
