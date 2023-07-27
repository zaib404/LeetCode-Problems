﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCode_Problems.Easy_Problems
{
    /// <summary>
    /// 70. Climbing Stairs
    /// You are climbing a staircase.It takes n steps to reach the top.
    /// 
    /// Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
    /// 
    /// Example 1:
    /// 
    /// Input: n = 2
    /// Output: 2
    /// Explanation: There are two ways to climb to the top.
    /// 1. 1 step + 1 step
    /// 2. 2 steps
    /// Example 2:
    /// 
    /// Input: n = 3
    /// Output: 3
    /// Explanation: There are three ways to climb to the top.
    /// 1. 1 step + 1 step + 1 step
    /// 2. 1 step + 2 steps
    /// 3. 2 steps + 1 step
    /// </summary>
    internal class Q70
    {
        public int ClimbStairs(int n)
        {
            if (n <= 0)
                return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            int steps = 0;

            for (int i = 0; i < n; i++)
            {

            }

            return steps;
        }
    }
}
