using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct11
{
    public class Solution
    {
        public string RemoveDuplicateLetters(string s)
        {
            HashSet<char> seen = new HashSet<char>();
            Dictionary<char, int> count = new Dictionary<char, int>();
            foreach(char c in s)
            {
                if (!count.ContainsKey(c))
                {
                    count.Add(c, 1);
                    continue;
                }
                count[c]++;
            }

            Stack<char> stack = new Stack<char>();

            foreach(char c in s)
            {
                if (seen.Contains(c))
                {
                    count[c]--;
                    continue;
                }

                while (stack.Count > 0 && stack.Peek() > c && count[stack.Peek()] > 1 )
                {
                    var last = stack.Pop();
                    count[last]--;
                    seen.Remove(last);
                }

                stack.Push(c);
                seen.Add(c);
            }

            Stack<char> rev = new Stack<char>();
            while (stack.Count > 0)
            {
                rev.Push(stack.Pop());
            }

            StringBuilder sb = new StringBuilder(stack.Count);
            while (rev.Count > 0)
            {
                sb.Append(rev.Pop());
            }

            return sb.ToString();           
        }
    }
}
