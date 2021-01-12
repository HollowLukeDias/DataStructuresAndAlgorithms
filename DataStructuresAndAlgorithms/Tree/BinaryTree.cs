using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Tree
{
    class BinaryTreeNode
    {
        public int Value;
        public BinaryTreeNode LeftNode;
        public BinaryTreeNode RightNode;

        public BinaryTreeNode(int value)
        {
            Value = value;
        }
    }
    class BinaryTree
    {
        private BinaryTreeNode _root;

        public void Insert(int value)
        {
            var newNode = new BinaryTreeNode(value);
            if (_root == null)
                _root = newNode;
            else
            {
                var currentNode = _root;
                var nextNode = (value < currentNode.Value) ? currentNode.LeftNode : currentNode.RightNode;
                while (true)
                {
                    if(nextNode == null)
                    {
                        if (value < currentNode.Value)
                            currentNode.LeftNode = newNode;
                        else if (value > currentNode.Value)
                            currentNode.RightNode = newNode;
                        return;

                    }
                    currentNode = nextNode;
                    nextNode = (value < currentNode.Value) ? currentNode.LeftNode : currentNode.RightNode;
                } 
            }
        }

        public bool LookUp(int value)
        {
            BinaryTreeNode currentNode = _root;
            BinaryTreeNode nextNode;
            while (true)
            {
                nextNode = (value < currentNode.Value) ? currentNode.LeftNode : currentNode.RightNode;
                if (nextNode == null)
                {
                    return false;
                }
                else if (nextNode.Value == value)
                {
                    return true;
                }
                currentNode = nextNode;
            }
        }
    }
}
