using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    /// <summary>
    /// 383. Ransom Note
    /// 
    /// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
    /// 
    /// Each letter in magazine can only be used once in ransomNote.
    /// 
    /// Example 1:
    /// Input: ransomNote = "a", magazine = "b"
    /// Output: false
    /// </summary>
    internal class Q383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            // if the magazine length is less than the ransom that means it cannot match.
            if (magazine.Length < ransomNote.Length)
            {
                return false;
            }

            string note = "";

            // ransom - abc
            // mag - cba

            for (int i = 0; i < ransomNote.Length; i++)
            {
                // a
                for (int j = 0; j < magazine.Length; j++)
                {
                    //c // b // a
                    if (ransomNote[i] == magazine[j])
                    {
                        note += ransomNote[i].ToString();
                        magazine = magazine.Remove(j, 1);
                        break;
                    }
                }
            }

            if (ransomNote == note)
            {
                return true;
            }

            return false;
        }

        public bool CanConstruct2(string ransomNote, string magazine)
        {
            // if the magazine length is less than the ransom that means it cannot match.
            if (magazine.Length < ransomNote.Length)
            {
                return false;
            }

            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (var letter in magazine)
            {
                if (map.ContainsKey(letter))
                {
                    map[letter] += 1;
                }
                else
                {
                    map.Add(letter, 1);
                }
            }

            foreach (char letter in ransomNote)
            {
                if (!map.ContainsKey(letter)) { return false; }
                else
                {
                    map[letter] -= 1;

                    if (map[letter] == 0)
                    {
                        map.Remove(letter);
                    }
                }
            }
            return true;
        }
    }
}
