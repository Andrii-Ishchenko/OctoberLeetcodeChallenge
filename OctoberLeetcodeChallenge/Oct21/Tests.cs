using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct21
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
            int[] A = new int[] { 5, 10, -5 };
            int[] expected = new int[] { 5, 10 };
            CollectionAssert.AreEqual(expected, _solution.AsteroidCollision(A));
        }

        [Test]
        public void Test2()
        {
            int[] A = new int[] { -2, -1, 1, 2, 3 };
            int[] expected = new int[] { -2, -1, 1, 2, 3 };
            CollectionAssert.AreEqual(expected, _solution.AsteroidCollision(A));
        }

        [Test]
        public void Test3()
        {
            int[] A = new int[] { 8, -8 };
            int[] expected = new int[] {  };
            CollectionAssert.AreEqual(expected, _solution.AsteroidCollision(A));
        }


        [Test]
        public void Test4()
        {
            int[] A = new int[] { 10, 2, -5 };
            int[] expected = new int[] { 10};
            CollectionAssert.AreEqual(expected, _solution.AsteroidCollision(A));
        }

        [Test]
        public void Test5()
        {
            int[] A = new int[] { 10, 2, -5, 1, -40 };
            int[] expected = new int[] { -40 };
            CollectionAssert.AreEqual(expected, _solution.AsteroidCollision(A));
        }
    }
}
