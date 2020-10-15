using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct13
{
    public class Solution
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            return Sort(head);
        }
      
        public ListNode Sort(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode slowIt = head;
            ListNode fastIt = head.next;

            while (fastIt != null && fastIt.next != null)
            {
                slowIt = slowIt.next;
                fastIt = fastIt.next.next;              
            }
            var nextAfterMid = slowIt.next;
            slowIt.next = null;

            var a = Sort(head);
            var b = Sort(nextAfterMid);

            return Merge(a, b);
        }

        private ListNode Merge(ListNode x, ListNode y)
        {
            ListNode temp = new ListNode(0);
            ListNode it = temp;
            while(x !=null || y != null)
            {
                if(x == null)
                {
                    it.next = y;
                    return temp.next;
                }

                if(y == null)
                {
                    it.next = x;
                    return temp.next;
                }

                if(x.val > y.val)
                {
                    it.next = y;
                    it = it.next;
                    y = y.next;
                } 
                else
                {
                    it.next = x;
                    it = it.next;
                    x = x.next;
                }
            }
            return temp.next;
        }
    }
}
