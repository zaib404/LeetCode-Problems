using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Medium_Problems
{
    /// <summary>
    /// 852. Peak Index in a Mountain Array
    /// Medium
    /// An array arr a mountain if the following properties hold:
    /// 
    /// arr.length >= 3
    /// There exists some i with 0 < i<arr.length - 1 such that:
    /// arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
    /// arr[i]> arr[i + 1] > ... > arr[arr.length - 1]
    /// Given a mountain array arr, return the index i such that arr[0] < arr[1] < ... < arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1].
    /// 
    /// You must solve it in O(log(arr.length)) time complexity.
    /// </summary>
    internal class Q852
    {
        public int PeakIndexInMountainArray(int[] arr)
        {
            int peak = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i+1] > arr[i])
                {
                    peak++;
                }
                else
                {
                    break;
                }
            }

            return peak;
        }
    }
}
