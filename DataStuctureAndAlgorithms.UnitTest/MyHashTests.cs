using NUnit.Framework;
using DataStructuresAndAlgorithms.Hash;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStuctureAndAlgorithms.UnitTest
{
    [TestFixture]
    class MyHashTests
    {

        private MyHashTable _hash;

        [SetUp]
        public void SetUp()
        {
            _hash = new MyHashTable(100);
        }

        [TestCase("A", 65)]
        [TestCase("X", 88)]
        [TestCase("d", 0)]
        [TestCase("z", 22)]
        public void Hash_SingleCharString_ShouldReturnCharCodeModSize(string oneChar, int expectedResult)
        {
            Assert.That(MyHash.Hash(oneChar, _hash.Length), Is.EqualTo(expectedResult));
        }

        [TestCase("AA", 65)]
        [TestCase("AAA", 95)]
        [TestCase("AAAA", 90)]
        [TestCase("AAAB", 93)]
        [TestCase("AAAC", 96)]
        [TestCase("BBBB", 96)]
        [TestCase("dd", 0)]
        [TestCase("aa", 97)]
        [TestCase("aaa", 91)]
        [TestCase("xx", 20)]
        [TestCase("xxx", 60)]
        public void Hash_MultipleCharString_DoesTheFunctionProperly(string multipleChar, int expectedResult)
        {
            Assert.That(MyHash.Hash(multipleChar, _hash.Length), Is.EqualTo(expectedResult));
        }

        [TestCase("aaa", 103)]
        [TestCase("xx", 181941)]
        [TestCase("xxx", 14)]
        [TestCase("A", 45)]
        [TestCase("m", 1828)]
        [TestCase("Lucas", 0)]
        [TestCase("Jenifer", 1)]
        public void SetAndGet_WhenCalled_SetsTheValueIntoTheCorrectIndex(string key, int value)
        {
            _hash.Set(key, value);
            Assert.That(_hash.Get(key), Is.EqualTo(value));
        }
    }
}
