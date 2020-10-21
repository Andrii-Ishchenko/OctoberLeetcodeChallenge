using System;
using System.Collections.Generic;
using System.Text;

namespace OctoberLeetcodeChallenge.Oct18
{
    public class Solution
    {
        public int MaxProfit(int k, int[] prices)
        {
            int n = prices.Length;
            if(k == 0 || n < 2)
            {
                return 0;
            }


            if(2*k > n)
            {
                int res = 0;

                for(int i=1; i<prices.Length; i++)
                {
                    res += Math.Max(0, prices[i] - prices[i - 1]);
                }
                return res;
            }

            int[,,] dp = new int[n, k+1, 2];
            //dp[day,used_transactions, hold]
            //hold: 1-hold, 0-not hold
            //hold: numbedr of shares at end of i day: 0/1
            for(int i = 0; i < n; i++)
            {
                for(int j=0; j<=k; j++)
                {
                    dp[i, j, 0] = -1_000_000_000;
                    dp[i, j, 1] = -1_000_000_000;
                }
            };

            dp[0, 0, 0] = 0;
            dp[0, 1, 1] = -prices[0];

            for(int i=1; i < n; i++)
            {
                for(int j = 0; j <= k; j++)
                {
                    // keep hold dp[i,j,1] = dp[i-1,j,1]
                    // keep not holding dp[i,j,0] = dp[i-1,j,0]
                    // buy if(j>0): dp[i,j,1] = dp[i-1][j-1][0] - prices[i]
                    // sell dp[i,j,0] = dp[i-1,j,1] + prices[i]
                    dp[i, j, 0] = Math.Max(dp[i - 1, j, 0], dp[i - 1, j, 1] + prices[i]);
                    if (j > 0)
                    {
                        dp[i, j, 1] = Math.Max(dp[i - 1, j, 1], dp[i-1, j-1, 0] - prices[i]);
                    }

                }
            }

            int max = 0;
            for(int i = 0; i<=k; i++)
            {
                max = Math.Max(max, dp[n - 1, i, 0]);
            }

            return max;
        }
    }
}
