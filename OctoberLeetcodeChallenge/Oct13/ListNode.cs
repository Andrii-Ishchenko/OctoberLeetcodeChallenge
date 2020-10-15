using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct13
{
    [DebuggerDisplay("[{val}]")]
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
