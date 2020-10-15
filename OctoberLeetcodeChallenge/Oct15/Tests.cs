using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct15
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
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            _solution.Rotate(nums, 3);
            Assert.Pass();
        }
    }
}
