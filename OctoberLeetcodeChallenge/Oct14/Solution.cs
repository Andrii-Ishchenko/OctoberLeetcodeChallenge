using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct14
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            return Math.Max(Rob(nums, 0, nums.Length - 1), Rob(nums, 1, nums.Length - 1));
        }

        public int Rob(int[] nums, int start, int count)
        {
            if(count == 1)
            {
                return nums[start];
            }

            int[] rob = new int[count];
            rob[0] = nums[start];
            rob[1] = Math.Max(nums[start], nums[start + 1]);
            int max = rob[1];

            for (int i = 2; i < count; i++)
            {
                rob[i] = Math.Max(rob[i - 2] + nums[start + i], rob[i - 1]);
                if (rob[i] > max)
                {
                    max = rob[i];
                }
            }

            return max;
        }
    }
}
