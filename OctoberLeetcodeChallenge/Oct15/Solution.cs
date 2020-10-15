using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct15
{
    class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            int l = nums.Length;
            if (l < 2) return;

            k = k % l;
            if (k == 0) return;

            int nod = GCD(l, k);
            int m = l / nod;
            int prev = nums[0];
            int temp;

            for (int start = 0; start < nod; start++)
            {
                for (int i = 0; i <= m; i++)
                {
                    int currentIndex = (start + i * k) % l;
                    Debug.WriteLine($"i:{i} ind:{currentIndex}");
                    temp = nums[currentIndex];
                    nums[currentIndex] = prev;
                    prev = temp;
                }
            }
            Debugger.Break();
        }

        private int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }
    }
}
