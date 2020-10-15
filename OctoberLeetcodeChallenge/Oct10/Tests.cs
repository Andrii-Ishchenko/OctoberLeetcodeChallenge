using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct10
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
            var arr = new int[][] {
                new int[] {10, 16},
                new int[] {2, 8},
                new int[] {1, 6},
                new int[] {7, 12}
            };

            Assert.AreEqual(2,_solution.FindMinArrowShots(arr));
        }

        [Test]
        public void Test2()
        {
            var arr = new int[][] {
                new int[] {1, 2},
                new int[] {3, 4},
                new int[] {5, 6},
                new int[] {7, 8}
            };
            Assert.AreEqual(4, _solution.FindMinArrowShots(arr));
        }

        [Test]
        public void Test3()
        {
            var arr = new int[][] {
                new int[] {1, 2},
                new int[] {2, 3},
                new int[] {3, 4},
                new int[] {4, 5}
            };
            Assert.AreEqual(2, _solution.FindMinArrowShots(arr));
        }

        [Test]
        public void Test4()
        {
            var arr = new int[][] {
                new int[] {1, 2}
            };
            Assert.AreEqual(1, _solution.FindMinArrowShots(arr));
        }

        [Test]
        public void Test5()
        {
            var arr = new int[][] {
                new int[] {2, 3},
                new int[] {2, 3}
            };
            Assert.AreEqual(1, _solution.FindMinArrowShots(arr));
        }
    }
}
