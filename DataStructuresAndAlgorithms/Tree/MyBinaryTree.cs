using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Tree
{
    public class BinaryTreeNode
    {
        public int Value;
        public BinaryTreeNode LeftNode;
        public BinaryTreeNode RightNode;

        public BinaryTreeNode(int value)
        {
            Value = value;
        }
    }
    public class MyBinaryTree
    {
        public BinaryTreeNode Root;

        public void Insert(int value)
        {
            var newNode = new BinaryTreeNode(value);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                var currentNode = Root;
                var nextNode = (value < currentNode.Value) ? currentNode.LeftNode : currentNode.RightNode;
                while (true)
                {
                    if(nextNode == null)
                    {
                        if (value < currentNode.Value)
                        {
                            currentNode.LeftNode = newNode;
                        }
                        else if (value > currentNode.Value)
                        {
                            currentNode.RightNode = newNode;
                        }

                        return;
                    }
                    currentNode = nextNode;
                    nextNode = (value < currentNode.Value) ? currentNode.LeftNode : currentNode.RightNode;
                } 
            }
        }

        public bool LookUp(int value)
        {
            BinaryTreeNode currentNode = Root;
            BinaryTreeNode nextNode;

            if (value == Root.Value)
                return true;

            while (true)
            {
                nextNode = (value < currentNode.Value) ? currentNode.LeftNode : currentNode.RightNode;
                
                if (nextNode == null)
                    return false;
                else if (nextNode.Value == value)
                    return true;

                currentNode = nextNode;
            }
        }

        public BinaryTreeNode GetNode(int value)
        {
            BinaryTreeNode currentNode = Root;
            BinaryTreeNode nextNode;

            if (value == Root.Value)
                return Root;

            while (true)
            {
                nextNode = (value < currentNode.Value) ? currentNode.LeftNode : currentNode.RightNode;

                if (nextNode == null)
                    return null;
                else if (nextNode.Value == value)
                    return nextNode;

                currentNode = nextNode;
            }
        }

        public void Delete(int value)
        {

        }

        public List<string> Traverse(BinaryTreeNode node, List<string> stringTree)
        {
            stringTree.Add(node.Value.ToString());
            if (node.LeftNode != null)
                Traverse(node.LeftNode, stringTree);
            if (node.RightNode != null)
                Traverse(node.RightNode, stringTree);
            return stringTree;
        }

        
    }

    public static class BTreePrinter
    {
        class NodeInfo
        {
            public BinaryTreeNode Node;
            public string Text;
            public int StartPos;
            public int Size { get { return Text.Length; } }
            public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
            public NodeInfo Parent, Left, Right;
        }

        public static void Print(this BinaryTreeNode root, string textFormat = "0", int spacing = 1, int topMargin = 2, int leftMargin = 2)
        {
            if (root == null) return;
            int rootTop = Console.CursorTop + topMargin;
            var last = new List<NodeInfo>();
            var next = root;
            for (int level = 0; next != null; level++)
            {
                var item = new NodeInfo { Node = next, Text = next.Value.ToString(textFormat) };
                if (level < last.Count)
                {
                    item.StartPos = last[level].EndPos + spacing;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = leftMargin;
                    last.Add(item);
                }
                if (level > 0)
                {
                    item.Parent = last[level - 1];
                    if (next == item.Parent.Node.LeftNode)
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos - 1);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos + 1);
                    }
                }
                next = next.LeftNode ?? next.RightNode;
                for (; next == null; item = item.Parent)
                {
                    int top = rootTop + 2 * level;
                    Print(item.Text, top, item.StartPos);
                    if (item.Left != null)
                    {
                        Print("/", top + 1, item.Left.EndPos);
                        Print("_", top, item.Left.EndPos + 1, item.StartPos);
                    }
                    if (item.Right != null)
                    {
                        Print("_", top, item.EndPos, item.Right.StartPos - 1);
                        Print("\\", top + 1, item.Right.StartPos - 1);
                    }
                    if (--level < 0) break;
                    if (item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos + 1;
                        next = item.Parent.Node.RightNode;
                    }
                    else
                    {
                        if (item.Parent.Left == null)
                            item.Parent.EndPos = item.StartPos - 1;
                        else
                            item.Parent.StartPos += (item.StartPos - 1 - item.Parent.EndPos) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
        }

        private static void Print(string s, int top, int left, int right = -1)
        {
            Console.SetCursorPosition(left, top);
            if (right < 0) right = left + s.Length;
            while (Console.CursorLeft < right) Console.Write(s);
        }
    }
}
