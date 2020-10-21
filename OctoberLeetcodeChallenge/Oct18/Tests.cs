using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct18
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
            int[] prices = new int[] {2 ,4, 1};
            Assert.AreEqual(2, _solution.MaxProfit(2, prices));
        }

        [Test]
        public void Test2()
        {
            int[] prices = new int[] { 3, 2, 6, 5, 0, 3 };
            Assert.AreEqual(7, _solution.MaxProfit(2, prices));
        }

        [Test]
        public void Test3()
        {
            int[] prices = new int[] { 1, 2, 3, 5, 9, 11 };
            Assert.AreEqual(10, _solution.MaxProfit(1, prices));
        }

        [Test]
        public void Test4()
        {
            int[] prices = new int[] { 1, 2, 3, 5, 9, 11 };
            Assert.AreEqual(10, _solution.MaxProfit(100, prices));
        }

        [Test]
        public void Test5()
        {
            int[] prices = new int[] { 1, 2, 9, 11 };
            Assert.AreEqual(10, _solution.MaxProfit(1, prices));
        }
    }
}
