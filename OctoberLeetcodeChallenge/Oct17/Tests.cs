using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct17
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
            var list = _solution.FindRepeatedDnaSequences("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT");

            Assert.AreEqual(2, list.Count);
            var expected = new List<string>() { "AAAAACCCCC", "CCCCCAAAAA" };
            CollectionAssert.AreEquivalent(expected, list);
        }

        [Test]
        public void Test2()
        {
            var list = _solution.FindRepeatedDnaSequences("AAAAAAAAAAAAA");

            Assert.AreEqual(1, list.Count);
            var expected = new List<string>() { "AAAAAAAAAA" };
            CollectionAssert.AreEquivalent(expected, list);
        }
    }
}
