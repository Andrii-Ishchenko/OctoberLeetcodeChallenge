using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct14
{
    class Tests
    {
        private Solution _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new Solution();
        }

        [Test]
        public void Test1()
        {
            var nums = new int[] { 2, 3, 2};
            Assert.AreEqual(3, _solution.Rob(nums));
        }

        [Test]
        public void Test2()
        {
            var nums = new int[] { 1, 2, 3, 1 };
            Assert.AreEqual(4, _solution.Rob(nums));
        }

        [Test]
        public void Test3()
        {
            var nums = new int[] { 0 };
            Assert.AreEqual(0, _solution.Rob(nums));
        }

        [Test]
        public void Test4()
        {
            var nums = new int[] { 1, 3, 1, 3, 100 };
            Assert.AreEqual(103, _solution.Rob(nums));
        }
    }
}
