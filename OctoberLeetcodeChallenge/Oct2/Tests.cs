using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct2
{
    public class Tests
    {

        SumOfCombination sumOfCombination;

        [OneTimeSetUp]
        public void Setup()
        {
            sumOfCombination = new SumOfCombination();
        }

        [Test]
        public void Test1()
        {
            var result = sumOfCombination.CombinationSum(new int[] { 2, 3, 6, 7 }, 7);

            Assert.AreEqual(2, result.Count);
            CollectionAssert.AreEquivalent(new int[] { 2, 2, 3 }, result[0]);
            CollectionAssert.AreEquivalent(new int[] {7}, result[1]);
        }

        [Test]
        public void Test2()
        {
            var result = sumOfCombination.CombinationSum(new int[] { 2, 3, 5 }, 8);

            Assert.AreEqual(3, result.Count);
            CollectionAssert.AreEquivalent(new int[] { 2, 2, 2, 2 }, result[0]);
            CollectionAssert.AreEquivalent(new int[] { 2, 3, 3 }, result[1]);
            CollectionAssert.AreEquivalent(new int[] { 3, 5 }, result[2]);
        }

        [Test]
        public void Test3()
        {
            var result = sumOfCombination.CombinationSum(new int[] { 2 }, 1);

            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void Test4()
        {
            var result = sumOfCombination.CombinationSum(new int[] { 1 }, 1);

            Assert.AreEqual(1, result.Count);
            CollectionAssert.AreEquivalent(new int[] { 1 }, result[0]);
        }

        [Test]
        public void Test5()
        {
            var result = sumOfCombination.CombinationSum(new int[] { 1 }, 2);

            Assert.AreEqual(1, result.Count);
            CollectionAssert.AreEquivalent(new int[] { 1, 1 }, result[0]);
        }
    }
}
