using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    /// <summary>
    /// 13. Roman to Integer
    /// 
    /// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    /// 
    /// Symbol       Value
    /// I             1
    /// V             5
    /// X             10
    /// L             50
    /// C             100
    /// D             500
    /// M             1000
    /// 
    /// For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
    /// 
    /// Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII. 
    /// Instead, the number four is written as IV.Because the one is before the five we subtract it making four. 
    /// The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:
    /// 
    /// I can be placed before V (5) and X(10) to make 4 and 9. 
    /// X can be placed before L(50) and C(100) to make 40 and 90. 
    /// C can be placed before D(500) and M(1000) to make 400 and 900.
    /// Given a roman numeral, convert it to an integer.
    /// 
    /// Example 1:
    /// Input: s = "III"
    /// Output: 3
    /// Explanation: III = 3.
    /// </summary>
    internal class Q13
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> romanNum = new Dictionary<string, int>()
            {
                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L", 50},
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 }
            };

            List<int> listSum = new List<int>();
            string letter1, letter2;
            int val1, val2;

            for (int i = 0; i < s.Length; i++)
            {
                // check if it is the end
                if (i == (s.Length - 1))
                {
                    letter1 = s[i].ToString();
                    listSum.Add(romanNum[letter1]);
                }
                else
                {
                    // get current letter value, then the next two
                    letter1 = s[i].ToString();
                    letter2 = s[i + 1].ToString();

                    val1 = romanNum[letter1];
                    val2 = romanNum[letter2];

                    if (val1 < val2)
                    {
                        listSum.Add(val2 - val1);
                        i++;
                    }
                    else
                    {
                        listSum.Add(val1);
                    }

                }
            }

            return listSum.Sum();
        }
    }
}
