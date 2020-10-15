using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct7
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
            var listNode1 = new ListNode(1);
            var listNode2 = new ListNode(2);
            var listNode3 = new ListNode(3);
            var listNode4 = new ListNode(4);
            var listNode5 = new ListNode(5);

            listNode1.next = listNode2;
            listNode2.next = listNode3;
            listNode3.next = listNode4;
            listNode4.next = listNode5;
            listNode5.next = null;

            var list = _solution.RotateRight(listNode1, 2);
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            var listNode1 = new ListNode(1);
            var listNode2 = new ListNode(2);

            listNode1.next = listNode2;
            listNode2.next = null;

            var list = _solution.RotateRight(listNode1, 2);
            Assert.Pass();
        }
    }
}
