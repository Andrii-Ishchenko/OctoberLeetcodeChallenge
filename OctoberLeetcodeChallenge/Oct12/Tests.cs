using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct12
{
    public class Tests
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
            Assert.AreEqual(true, _solution.BuddyStrings("ab", "ba"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, _solution.BuddyStrings("ab", "ab"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(true, _solution.BuddyStrings("aa", "aa"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(true, _solution.BuddyStrings("aaaaaaabc", "aaaaaaacb"));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(false, _solution.BuddyStrings("", "aa"));
        }
    }
}
