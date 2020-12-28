using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.Hash
{

    class Node
    {
        public string Key { get; set; }
        public int Value  { get; set; }

        public Node(string key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    public class MyHashTable
    {
        private class Nodes
        {
            public List<Node> insideNodes;
        }

        private readonly Nodes[] _data;
        public readonly int Length;

        public MyHashTable(int size)
        {
            _data = new Nodes[size];
            Length = size;
        }

        public void Set(string key, int value)
        {
            var hash = MyHash.Hash(key, Length);
            var node = new Node(key, value);

            if (_data[hash] == null)
            {
                _data[hash] = new Nodes
                {
                    insideNodes = new List<Node>()
                };
            }
                

            _data[hash].insideNodes.Add(node);
        }

        public int Get(string key)
        {
            var hash = MyHash.Hash(key, Length);
            if (_data[hash] == null)
                return 0;

            foreach (var node in _data[hash].insideNodes)
            {
                if (node.Key.Equals(key))
                {
                    return node.Value;
                }
            }
            return 0;
        }
    }
}
