using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct3
{
    public class KDiffPairs
    {
        public int FindPairs(int[] nums, int k)
        {
            HashSet<int> set = new HashSet<int>(nums.Length);
            int count = 0;
            if (k == 0)
            {
                HashSet<int> paired = new HashSet<int>();
                foreach (var num in nums)
                {
                    if (set.Contains(num))
                    {
                        if (!paired.Contains(num))
                        {
                            count++;
                            paired.Add(num);
                        }
                    }
                    else
                    {
                        set.Add(num);
                    }                                    
                }
            } 
            else 
            {
                foreach (var num in nums)
                {
                    if (set.Contains(num)) continue;
                    if (set.Contains(num - k)) count++;
                    if (set.Contains(num + k)) count++;
                    set.Add(num);
                }
            }
            return count;
        }
    }
}
