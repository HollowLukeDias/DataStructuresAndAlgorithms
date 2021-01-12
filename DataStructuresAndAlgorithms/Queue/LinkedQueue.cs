using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Queue
{
    class Node
    {
        public object Obj;
        public Node next;

        public Node(object obj)
        {
            Obj = obj;
        }
    }
    class LinkedQueue
    {
        private Node _top;
        private Node _bottom;
        private int _length;

        public object Peek()
        {
            if (_length == 0)
                return null;
            return _bottom;
        }

        public void Enqueue(object obj)
        {
            var newNode = new Node(obj);

            if (_length == 0)
            {
                _bottom = newNode;
                _top = newNode;
            }
            else
            {
                _top.next = newNode;
            }

            _length++;
        }

        public object Dequeue()
        {
            if (_length == 0)
                return null;
            else if (_length == 1)
            {

            }
        }

    }
}
