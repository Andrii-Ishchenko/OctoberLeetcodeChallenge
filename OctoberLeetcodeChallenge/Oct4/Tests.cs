using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct4
{
    class Tests
    {
        private CoveredIntervals _problem;
        [SetUp]
        public void Setup()
        {
            _problem = new CoveredIntervals();
        }

        [Test]
        public void Test0()
        {
            int[][] intervals = new int[7][];

            intervals[0] = new int[] { 1, 3 };
            intervals[1] = new int[] { 2, 3 };
            intervals[2] = new int[] { 3, 5 };
            intervals[3] = new int[] { 1, 5 };
            intervals[4] = new int[] { 3, 9 };
            intervals[5] = new int[] { 3, 8 };
            intervals[6] = new int[] { 2, 7 };

            var result = _problem.RemoveCoveredIntervals(intervals);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test1()
        {
            int[][] intervals = new int[3][];

            intervals[0] = new int[] { 1, 4 };
            intervals[1] = new int[] { 3, 6 };
            intervals[2] = new int[] { 2, 8 };


            var result = _problem.RemoveCoveredIntervals(intervals);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test2()
        {
            int[][] intervals = new int[2][];

            intervals[0] = new int[] { 1, 4 };
            intervals[1] = new int[] { 2, 3 };


            var result = _problem.RemoveCoveredIntervals(intervals);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test3()
        {
            int[][] intervals = new int[2][];

            intervals[0] = new int[] { 0, 10 };
            intervals[1] = new int[] { 5, 12 };


            var result = _problem.RemoveCoveredIntervals(intervals);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test4()
        {
            int[][] intervals = new int[3][];

            intervals[0] = new int[] { 3, 10 };
            intervals[1] = new int[] { 4, 10 };
            intervals[2] = new int[] { 5, 11 };


            var result = _problem.RemoveCoveredIntervals(intervals);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test5()
        {
            int[][] intervals = new int[3][];

            intervals[0] = new int[] { 1, 2 };
            intervals[1] = new int[] { 1, 4 };
            intervals[2] = new int[] { 3, 4 };


            var result = _problem.RemoveCoveredIntervals(intervals);
            Assert.AreEqual(1, result);
        }
    }
}
