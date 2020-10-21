using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct17
{
    public class Solution
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            List<string> results = new List<string>();
            if (s.Length <= 10)
            {
                return results;
            }

            Dictionary<int,int> seen = new Dictionary<int,int>();
            char[] chars = new char[10];
            int current = 0;
            
            for(int i=0; i<s.Length; i++)
            {
                char c = s[i];         
                for(int j = 1; j < 10; j++)
                {
                    chars[j - 1] = chars[j];
                }
                chars[9] = c;

                current = current & ((1 << 18) - 1);

                if (c == 'A')
                {
                    current = (current << 2) + 0;
                } 
                else if (c == 'C')
                {
                    current = (current << 2) + 1;
                }
                else if (c == 'G')
                {
                    current = (current << 2) + 2;
                }
                else if (c == 'T')
                {
                    current = (current << 2) + 3;
                }

                if (i < 9) continue;

                if (seen.ContainsKey(current))
                {
                    if(seen[current]++ == 1)
                    {
                        results.Add(new string(chars));
                    }
                } 
                else
                {
                    seen[current] = 1;
                }
            }
            return results;
        }
    }
}
    