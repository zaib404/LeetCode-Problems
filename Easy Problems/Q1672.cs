using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Easy_Problems
{
    /// <summary>
    /// 1672. Richest Customer Wealth
    /// 
    /// You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
    /// 
    /// A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.
    /// 
    /// Example 1:
    /// Input: accounts = [[1,2,3],[3,2,1]]
    /// Output: 6
    /// Explanation:
    /// 1st customer has wealth = 1 + 2 + 3 = 6
    /// 2nd customer has wealth = 3 + 2 + 1 = 6
    /// Both customers are considered the richest with a wealth of 6 each, so return 6.
    /// </summary>
    internal class Q1672
    {
        public int MaximumWealth(int[][] accounts)
        {
            int maxSum = 0;
            int currentSum = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    currentSum += accounts[i][j];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                currentSum = 0;
            }

            return maxSum;
        }
    }
}
