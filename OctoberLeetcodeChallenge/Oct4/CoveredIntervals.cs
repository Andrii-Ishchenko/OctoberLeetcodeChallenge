using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct4
{
    class CoveredIntervals
    {
        public int RemoveCoveredIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => {
                var c = x[0].CompareTo(y[0]);
                if (c != 0) return c;
                return y[1].CompareTo(x[1]);
            });

            int count = intervals.Length;
            bool[] covered = new bool[count];


            for(int i=0; i<intervals.Length; i++)
            {
                if (covered[i]) continue;

                var current = intervals[i];
                for(int j=i+1; j < intervals.Length; j++)
                {
                    if (covered[j]) continue;

                    var other = intervals[j];
                    if(other[0] > current[1])
                    {
                        break;
                    }

                    if (current[0] <= other[0] && current[1] >= other[1])
                    {
                        //other is covered by current
                        covered[j] = true;
                        count--;
                    }

                }
            }
            return count;
        }
    }
}
