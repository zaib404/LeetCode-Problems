using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    /// <summary>
    /// 412. Fizz Buzz
    /// 
    /// Given an integer n, return a string array answer (1-indexed) where:
    /// 
    /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    /// answer[i] == "Fizz" if i is divisible by 3.
    /// answer[i] == "Buzz" if i is divisible by 5.
    /// answer[i] == i(as a string) if none of the above conditions are true.
    /// 
    /// Example 1:
    /// Input: n = 3
    /// Output: ["1","2","Fizz"]
    /// </summary>
    internal class Q412
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> returnValue = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    returnValue.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    returnValue.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    returnValue.Add("Buzz");
                }
                else
                {
                    returnValue.Add(i.ToString());
                }
            }

            return returnValue;
        }
    }
}
