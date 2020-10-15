using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct12
{
    public class Solution
    {
        public bool BuddyStrings(string A, string B)
        {
            if (A.Length < 2 || B.Length < 2 || A.Length != B.Length)
            {
                return false;
            }

            List<(char a,char b)> diffChars = new List<(char a, char b)>();
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            int diffCount = 0;
            for(int i=0; i < A.Length; i++)
            {
                if (charCounts.ContainsKey(A[i]))
                {
                    charCounts[A[i]]++;
                }
                else
                {
                    charCounts[A[i]] = 1;
                }

                if (A[i] != B[i])
                {
                   
                    diffChars.Add((A[i],B[i]));
                    diffCount++;

                    if (diffCount > 2)
                    {
                        return false;
                    }
                }
            }

            if (diffCount == 1)
            {
                return false;
            }

            if (diffCount == 2)
            {
                char a1 = diffChars[0].a;
                char a2 = diffChars[1].a;
                char b1 = diffChars[0].b;
                char b2 = diffChars[1].b;

                return (a1 == b2 && a2 == b1);
            }

            if(diffCount == 0)
            {
                foreach(var pair in charCounts)
                {
                    if (pair.Value >= 2) return true;
                }
            }
            return false;
        }
    }
}
