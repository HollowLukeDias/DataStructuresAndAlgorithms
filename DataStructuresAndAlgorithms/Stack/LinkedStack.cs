using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Stack
{
    class Node
    {
        public object Obj;
        public Node next;
        
        public Node(object obj)
        {
            Obj = obj;
            next = null;
        }
    }
    class LinkedStack
    {
        public Node Top;
        public Node Bottom;
        public int Length;

        public LinkedStack()
        {
            Top = null;
            Bottom = null;
            Length = 0;
        }

        public object Peek()
        {
            if (Length == 0)
            {
                return Top.Obj;
            }
            else
            {
                return null;
            }
        }

        public void Push(object obj)
        {
            var newNode = new Node(obj);
            if (Length == 0)
            {
                Top = newNode;
                Bottom = newNode;
            }
            else
            {
                var holdingPointer = Top;
                Top = newNode;
                newNode.next = holdingPointer;
            }

            Length++;
        }

        public object Pop()
        {
            if (Length == 0)
            {
                return null;
            }
            else if (Length == 1)
            {
                Bottom = null;
            }

            var returnObj = Top.Obj;
            Top = Top.next;

            Length--;
            return returnObj;
        }
    }
}
