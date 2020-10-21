using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct19
{
    public class Solution
    {
        public int MinDominoRotations(int[] A, int[] B)
        {
            int l = A.Length;
            int a = A[0];
            int b = B[0];

            int aCount = 0;
            int bCount = 0;

            int aStreak = 1;
            int bStreak = 1;
            int doubles = a == b ? 1 : 0;
            for(int i=1; i < l; i++)
            {
                if (A[i] == B[i]) doubles++;

                if (a == A[i] || a == B[i]) aStreak++;
                if (b == A[i] || b == B[i]) bStreak++;

                if (a == B[i]  && a != A[i])
                {
                    aCount++;
                }

                if (b == A[i] && b != B[i])
                {
                    bCount++;
                }
            }

            int result = l + 1;

            if (aStreak != l && bStreak != l) return -1;

            if(aStreak == l)
            {
                result = Math.Min(aCount, l - aCount - doubles);
            } 

            if(bStreak == l)
            {
                result = Math.Min(result, bCount);
                result = Math.Min(result, l - bCount - doubles);
            }

            return result;
        }
    }
}
