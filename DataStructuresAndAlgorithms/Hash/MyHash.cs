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

    public class MyHash
    {
        private class Nodes
        {
            public List<Node> insideNodes;
        }

        private Nodes[] _data;
        private int _length;

        public MyHash(int size)
        {
            _data = new Nodes[size];
            _length = size;
        }

        private int Hash(string key)
        {
            var hash = 0;
            var helperNumber = 0;
            foreach (var letter in key)
            {
                hash = (hash + letter * helperNumber) % key.Length;
                helperNumber++;
            }

            return hash;
        }

        public void Set(string key, int value)
        {
            var hash = Hash(key);
            var node = new Node(key, value);

            if (_data[hash] == null)
                _data[hash] = new Nodes();

            _data[hash].insideNodes.Add(node);
        }

        public int Get(string key)
        {
            var hash = Hash(key);
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
