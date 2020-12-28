using DataStructuresAndAlgorithms.CodingChallenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStuctureAndAlgorithms.UnitTest
{
    [TestFixture]
    class CodingChallengesTests
    {

        [Test]
        public void FirstRepeatingItem_WhenNumbersRepeat_ReturnsCorrectNumber()
        {
            var list = new List<int> { 2, 5, 1, 2, 3, 5, 1, 2, 4 };
            
            Assert.That(FirstRepeating.FirstRepeatingItemGood(list), Is.EqualTo(2));
        }

        [Test]
        public void FirstRepeatingItem_WhenNumbersDontRepeat_ReturnsCorrectNumber()
        {
            var list = new List<int> { 2, 3, 4, 5 };

            Assert.That(FirstRepeating.FirstRepeatingItemGood(list), Is.EqualTo(null));
        }
    }
}
