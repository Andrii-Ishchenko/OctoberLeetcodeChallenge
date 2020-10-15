using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct10
{
    public class Solution
    {
        public int FindMinArrowShots(int[][] points)
        {
            if (points.Length == 0)
            {
                return 0;
            }

            Array.Sort(points, (x, y) => {return x[1] < y[1] ? -1 : 1; });

            int count = 1;
            int rightCoord = points[0][1];

            for(int i=1; i<points.Length; i++)
            {
                if(points[i][0] <= rightCoord)
                {
                    continue;
                }

                count++;
                rightCoord = points[i][1];
            }

            return count;
        }
    }
}
