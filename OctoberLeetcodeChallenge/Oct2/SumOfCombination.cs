using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct2
{
    public class SumOfCombination
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> solutions = new List<IList<int>>();
            Array.Sort(candidates);
            Solve(solutions, candidates, new Stack<int>(), 0, target);
            return solutions as IList<IList<int>>;
        }

        public void Solve(List<IList<int>> solutions, int[] candidates, Stack<int> combination, int startIndex, int target)
        {       
            if(target == 0)
            {
                solutions.Add(new List<int>(combination));
            }

            for (int i = startIndex; i < candidates.Length; i++)
            {
                var candidate = candidates[i];
                if (candidate > target) 
                    break;

                combination.Push(candidate);
                Solve(solutions, candidates, combination, i, target - candidate);
                combination.Pop();
            }
        }
    }
}
