using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct21
{
    public class Solution
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            foreach(var asteroid in asteroids)
            {
                if(stack.Count == 0 || asteroid > 0)
                {
                    stack.Push(asteroid);
                }
                else
                {
                    while(stack.Count >= 0)
                    {
                        if(stack.Count == 0)
                        {
                            stack.Push(asteroid);
                            break;
                        }

                        var top = stack.Peek();

                        if (top < 0)
                        {
                            stack.Push(asteroid);
                            break;
                        }

                        if (top < -asteroid)
                        {
                            stack.Pop();
                            continue;
                        } 

                        if (top == -asteroid)
                        {
                            stack.Pop();
                        }
                        break;
                    }
                }
            }
            var result = stack.ToArray();
            Array.Reverse(result);
            return result;
        }
    }
}
