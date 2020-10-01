using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct1
{
    public class RecentCounter
    {
        int callNumber = 0;
        int[] requests = new int[10000];
        int startIndex = 0;

        int cutOff = 3000;

        public RecentCounter() {}

        public int Ping(int t)
        {
            requests[callNumber++] = t;
            int start = startIndex;
            int end = callNumber;
            int mid;
            while (start < end)
            {
                mid = (start + end) / 2;
                if (requests[mid] < t - cutOff)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            return callNumber - start;
        }
    }
}
