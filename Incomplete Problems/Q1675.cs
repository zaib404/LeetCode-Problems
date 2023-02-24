using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode_Problems.Hard_Problems
{
    /// <summary>
    /// 1675. Minimize Deviation in Array
    /// 
    /// https://leetcode.com/problems/minimize-deviation-in-array/
    /// 
    /// You are given an array nums of n positive integers.
    /// You can perform two types of operations on any element of the array any number of times:
    /// If the element is even, divide it by 2.
    /// For example, if the array is [1,2,3,4], then you can do this operation on the last element, and the array will be[1, 2, 3, 2].
    /// If the element is odd, multiply it by 2.
    /// For example, if the array is [1,2,3,4], then you can do this operation on the first element, and the array will be[2, 2, 3, 4].
    /// The deviation of the array is the maximum difference between any two elements in the array.
    /// 
    /// Return the minimum deviation the array can have after performing some number of operations.
    /// Example 1:
    /// Input: nums = [1, 2, 3, 4]
    /// Output: 1
    /// Explanation: You can transform the array to [1,2,3,2], then to [2,2,3,2], then the deviation will be 3 - 2 = 1.
    /// 
    /// Example 2:
    /// Input: nums = [4, 1, 5, 20, 3]
    /// Output: 3
    /// Explanation: You can transform the array after two operations to[4, 2, 5, 5, 3], then the deviation will be 5 - 2 = 3.
    /// 
    /// Example 3:
    /// Input: nums = [2, 10, 8]
    /// Output: 3
    /// </summary>
    internal class Q1675
    {
        // Time Limit Exceeded - will need to do another day. when im better
        public int MinimumDeviation(int[] nums)
        {
            List<int> result = nums.ToList();

            List<int> sum = result;

            // multiply off numbers by 2 to make them even.
            for (int i = 0; i < result.Count; i++)
            {
                while (result[i] % 2 != 0)
                {
                    result[i] *= 2;
                }
            }

            // sort array
            result.Sort();

            bool canNoLongerDivide = false;

            // keep dividing the largest element by 2 untill its no longer even
            while (!canNoLongerDivide)
            {
                if (result[result.Count - 1] % 2 == 0)
                {
                    result[result.Count - 1] = result[result.Count - 1] /= 2;
                    result.Sort();
                }

                // check how many are even
                int howManyEven = 0;
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] % 2 == 0)
                    {
                        howManyEven++;
                    }
                }

                if (howManyEven == 0 || howManyEven == result.Count)
                    canNoLongerDivide = true;
            }

            result.Sort();

            return result[result.Count - 1] - result[0];
        }
    }
}
