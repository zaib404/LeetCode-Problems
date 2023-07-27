using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Easy_Problems
{
    /// <summary>
    /// 1961. Check If String Is a Prefix of Array
    /// Given a string s and an array of strings words, determine whether s is a prefix string of words.
    /// 
    /// A string s is a prefix string of words if s can be made by concatenating the first k strings in words for some positive k no larger than words.length.
    /// 
    /// Return true if s is a prefix string of words, or false otherwise.
    /// Example 1:
    /// 
    /// Input: s = "iloveleetcode", words = ["i","love","leetcode","apples"]
    /// Output: true
    /// Explanation:
    /// s can be made by concatenating "i", "love", and "leetcode" together.
    /// Example 2:
    /// 
    /// Input: s = "iloveleetcode", words = ["apples","i","love","leetcode"]
    /// Output: false
    /// Explanation:
    /// It is impossible to make s using a prefix of arr.
    /// </summary>
    internal class Q1961
    {
        public bool IsPrefixString(string s, string[] words)
        {
            string w = "";

            foreach (string word in words)
            {
                w += word;

                if (w == s)
                {
                    return true;
                }

                if (w.Length > s.Length)
                {
                    return false;
                }
            }

            return false;
        }
    }
}
