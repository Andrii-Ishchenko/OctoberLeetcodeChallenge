using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct11
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
            Assert.AreEqual("abc", _solution.RemoveDuplicateLetters("bcabc"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("acdb", _solution.RemoveDuplicateLetters("cbacdcbc"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("dacb", _solution.RemoveDuplicateLetters("ddcbacba"));
        }
    }
}
