using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct7
{
    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null) return head;

            int length = 1;
            ListNode it = head;
            while (it.next != null)
            {
                it = it.next;
                length++;
            }

            if (k >= length)
            {
                k = k % length;
                if (k == 0) return head;
            }

            Stack<ListNode> stack = new Stack<ListNode>(k + 1);

            int i = 0;

            it = head;
            while (i < length && it != null)
            {
                if (i >= length - k - 1)
                {
                    stack.Push(it);
                }
                it = it.next;
                i++;
            }

            while (stack.Count > 1)
            {
                var curr = stack.Pop();
                curr.next = head;
                head = curr;
            }
            var last = stack.Pop();
            last.next = null;

            return head;
        }
    }
}
