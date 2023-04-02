using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Medium_Problems
{
    internal class Q211
    {
        List<string> listWords = new List<string>();

        public Q211()
        {

        }

        public void AddWord(string word)
        {
            if (!listWords.Contains(word))
            {
                listWords.Add(word);
            }

        }

        public bool Search(string word)
        {

            if (word.Contains("."))
            {
                bool rtn = false;
                int wordCounter = 0;

                foreach (var letter in word)
                {
                    if (letter.ToString() != ".")
                    {

                    }
                }


            }
            else
            {
                if (listWords.Contains(word))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
