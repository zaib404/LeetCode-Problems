using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Hard_Problems
{
    /// <summary>
    /// 4. Median of Two Sorted Arrays
    /// 
    /// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
    /// 
    /// The overall run time complexity should be O(log (m+n)).
    /// 
    /// Example 1:
    /// Input: nums1 = [1,3], nums2 = [2]
    /// Output: 2.00000
    /// Explanation: merged array = [1, 2, 3] and median is 2.
    /// Example 2:
    /// Input: nums1 = [1,2], nums2 = [3,4]
    /// Output: 2.50000
    /// Explanation: merged array = [1, 2, 3, 4] and median is (2 + 3) / 2 = 2.5.
    /// </summary>
    internal class Q4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> combinedArray = nums1.ToList();
            combinedArray.AddRange(nums2.ToList());
            combinedArray.Sort();

            double answer = 0;

            int arrayIndex = 0;

            if (combinedArray.Count % 2 == 0 ) 
            {
                // even
                arrayIndex = (int)((combinedArray.Count / 2) - 1);
                answer = combinedArray[arrayIndex] + combinedArray[arrayIndex + 1];
                answer /= 2;
            }
            else
            {
                //(odd / 2) + .5
                arrayIndex = (int)((combinedArray.Count / 2) + 0.5);
                answer = combinedArray[arrayIndex];
            }
            return answer;
        }
    }
}
