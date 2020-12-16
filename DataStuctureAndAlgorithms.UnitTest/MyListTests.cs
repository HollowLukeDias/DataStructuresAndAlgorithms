using DataStructuresAndAlgorithms;
using NUnit.Framework;

namespace DataStuctureAndAlgorithms.UnitTest
{
    [TestFixture]
    public class MyListTests
    {
        private MyList list;
        private MyList filledList;
        [SetUp]
        public void Setup()
        {
            list = new MyList();
        }

        [TestCase(1)]
        [TestCase("Jenn")]
        [TestCase('c')]
        [TestCase(10.12F)]
        [TestCase(1200.199)]
        public void Push_WhenCalled_ReturnCorrectObject(object itemToPush)
        {
            var item = list.Push(itemToPush);

            Assert.That(item, Is.EqualTo(itemToPush));
        }

        [Test]
        public void Push_WhenCalledTwice_AddTwoObjects()
        {
            list.Push(1);
            list.Push(2);

            Assert.That(list.Length, Is.EqualTo(2));
        }

        [Test]
        public void Push_ObjectsOfDifferentTypesPassed_WorkNormally()
        {
            list.Push(1);
            list.Push("now");

            Assert.That(list.Get(0), Is.EqualTo(1));
            Assert.That(list.Get(1), Is.EqualTo("now"));
        }

        [Test]
        public void Push_MoreThanOneObject_IncreaseArraySize()
        {
            list.Push(10);
            list.Push("love");

            Assert.That(list.Data.Length, Is.EqualTo(2));
        }

        [Test]
        public void Get_WhenCalled_ReturnObject()
        {
            list.Push(90);
            list.Push("oi");
            list.Push(80.121);

            Assert.That(list.Get(1), Is.EqualTo("oi"));
        }

        [Test]
        public void Get_WhenOutOfRange_ThrowsException()
        {
            Assert.That(() => list.Get(2), Throws.Exception);
        }
    }
}