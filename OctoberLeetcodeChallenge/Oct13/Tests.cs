using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace OctoberLeetcodeChallenge.Oct13
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
            var head = new ListNode(5);
            var listNode2 = new ListNode(4);
            var listNode3 = new ListNode(3);
            var listNode4 = new ListNode(2);
            var listNode5 = new ListNode(1);
            var listNode6 = new ListNode(0);

            head.next = listNode2;
            listNode2.next = listNode3;
            listNode3.next = listNode4;
            listNode4.next = listNode5;
            listNode5.next = listNode6;
            listNode6.next = null;

            var list = _solution.SortList(head);

            ListNode it = list;
            while (it.next!= null)
            {
                Assert.IsTrue(it.val <= it.next.val);
                it = it.next;
            }
        }
    }
}
