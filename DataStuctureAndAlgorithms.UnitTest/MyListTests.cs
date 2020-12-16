using DataStructuresAndAlgorithms;
using NUnit.Framework;

namespace DataStuctureAndAlgorithms.UnitTest
{
    [TestFixture]
    public class MyListTests
    {
        private MyList emptyList;
        private MyList filledList;
        [SetUp]
        public void Setup()
        {
            emptyList = new MyList();

            filledList = new MyList();
            filledList.Push("first");
            filledList.Push("Jenn");
            filledList.Push("ACE");
            filledList.Push(71.12);
            filledList.Push("last");
        }

        [TestCase(1)]
        [TestCase("Jenn")]
        [TestCase('c')]
        [TestCase(10.12F)]
        [TestCase(1200.199)]
        public void Push_WhenCalled_ReturnCorrectObject(object itemToPush)
        {
            var item = emptyList.Push(itemToPush);

            Assert.That(item, Is.EqualTo(itemToPush));
        }

        [Test]
        public void Push_WhenCalledTwice_AddTwoObjects()
        {
            emptyList.Push(1);
            emptyList.Push(2);

            Assert.That(emptyList.Length, Is.EqualTo(2));
        }

        [Test]
        public void Push_ObjectsOfDifferentTypesPassed_WorkNormally()
        {
            emptyList.Push(1);
            emptyList.Push("now");

            Assert.That(emptyList.Get(0), Is.EqualTo(1));
            Assert.That(emptyList.Get(1), Is.EqualTo("now"));
        }

        [Test]
        public void Push_MoreThanOneObject_IncreaseArraySize()
        {
            emptyList.Push(10);
            emptyList.Push("love");

            Assert.That(emptyList.Data.Length, Is.EqualTo(2));
        }

        [Test]
        public void Get_WhenCalled_ReturnObject()
        {
            Assert.That(filledList.Get(0), Is.EqualTo("first"));
        }

        [Test]
        public void Get_WhenOutOfRange_ThrowsException()
        {
            Assert.That(() => emptyList.Get(2), Throws.Exception);
        }

        [Test]
        public void Pop_HasItems_RemoveTheItem()
        {
            filledList.Pop();

            Assert.That(filledList.Get(filledList.Length), Is.EqualTo(null));
        }


        [Test]
        public void Pop_HasItems_ReturnsRightObject()
        {
            var item = filledList.Pop();

            Assert.That(item, Is.EqualTo("last"));
        }

        [Test]
        public void Pop_DoesNotHaveItems_ThrowsException()
        {
            Assert.That(() => emptyList.Pop(), Throws.Exception);
        }

        [Test]
        public void Delete_ValidIndex_RemoveItem()
        {
            filledList.Delete(0);

            Assert.That(filledList.Get(0), Is.Not.EqualTo("first"));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void Delete_ValidIndex_ShiftItems(int index)
        {
            var expectedResult = filledList.Get(index + 1);
            filledList.Delete(index);

            Assert.That(filledList.Get(index), Is.EqualTo(expectedResult));
        }

        [Test]
        public void Delete_ValidIndex_LastItemIsNull()
        {
            filledList.Delete(2);

            Assert.That(filledList.Get(filledList.Length), Is.Null);
        }

        [Test]
        public void Delete_InvalidIndex_ThrowsException()
        {
            Assert.That(() => emptyList.Delete(0), Throws.Exception);
        }
    }
}