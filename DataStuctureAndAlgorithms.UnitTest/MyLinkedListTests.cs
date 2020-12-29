using DataStructuresAndAlgorithms.LinkedList;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStuctureAndAlgorithms.UnitTest
{
    [TestFixture]
    class MyLinkedListTests
    {
        MyLinkedList linkedList;

        [SetUp]
        public void SetUp()
        {
            linkedList = new MyLinkedList(0);
        }

        [TestCase(2)]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(16)]
        [TestCase(1024)]
        public void Append_WhenCalledOnce_AddsANodeToTheEndOfTheLinkedList(int data)
        {
            linkedList.Append(data);

            Assert.That(linkedList.Get(1), Is.EqualTo(data));
        }

        [TestCase(4)]
        [TestCase(16)]
        [TestCase(64)]
        [TestCase(256)]
        [TestCase(1024)]
        public void Prepend_WhenCalledOnce_AddsANodeToTheBeginningOfTheLinkedList(int data)
        {
            linkedList.Prepend(data);

            Assert.That(linkedList.Get(0), Is.EqualTo(data));
        }

        [TestCase(4, 0)]
        [TestCase(16, 2)]
        [TestCase(64, 1)]
        [TestCase(256, 3)]
        [TestCase(1024, 4)]
        public void Insert_WhenCalledOnce_AddsANodeToTheCorrectPostionOnTheLinkedList(int data, int index)
        {
            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);
            linkedList.Append(5);
            linkedList.Insert(index, data);

            Assert.That(linkedList.Get(index), Is.EqualTo(data));
        }

        [Test]
        public void Append_WhenCalledMultipleTimes_AddsNodesCorrectly()
        {
            linkedList.Append(10);
            linkedList.Append(100);
            linkedList.Append(1000);
            linkedList.Append(10000);

            var correctList = new List<int> { 0, 10, 100, 1000, 10000 };

            Assert.That(linkedList.GetAll(), Is.EqualTo(correctList));
        }

        [Test]
        public void Prepend_WhenCalledMultipleTimes_AddsNodesCorrectly()
        {
            linkedList.Prepend(10);
            linkedList.Prepend(100);
            linkedList.Prepend(1000);
            linkedList.Prepend(10000);

            var correctList = new List<int> { 10000, 1000, 100, 10, 0};

            Assert.That(linkedList.GetAll(), Is.EqualTo(correctList));
        }

        [Test]
        public void Insert_WhenCalledMultipleTimes_AddsNodesCorrectly()
        {
            linkedList.Insert(0, 10);
            linkedList.Insert(1, 100);
            linkedList.Insert(1, 1000);
            linkedList.Insert(2, 10000);

            var correctList = new List<int> { 10, 1000, 10000, 100, 0};

            Assert.That(linkedList.GetAll(), Is.EqualTo(correctList));
        }


    }
}
