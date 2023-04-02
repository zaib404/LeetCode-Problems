using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Easy_Problems
{
    /// <summary>
    /// 1539. Kth Missing Positive Number
    /// Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
    /// Return the kth positive integer that is missing from this array.
    /// Example 1:
    /// Input: arr = [2, 3, 4, 7, 11], k = 5
    /// Output: 9
    /// Explanation: The missing positive integers are[1, 5, 6, 8, 9, 10, 12, 13, ...]. The 5th missing positive integer is 9.
    /// Example 2:
    /// Input: arr = [1, 2, 3, 4], k = 2
    /// Output: 6
    /// Explanation: The missing positive integers are[5, 6, 7, ...]. The 2nd missing positive integer is 6.
    /// </summary>
    internal class Q1539
    {
        public int FindKthPositive(int[] arr, int k)
        {
            int missingPos = 0;
            int counter = 0;
            int sum = arr.Sum() + k;

            for (int i = 1; i <= sum + k; i++)
            {
                if (!arr.Contains(i))
                {
                    counter++;
                }

                if (counter == k)
                {
                    missingPos = i;
                    break;
                }
            }

            return missingPos;
        }
    }
}
