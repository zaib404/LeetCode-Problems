using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Easy_Problems
{
    internal class Q605
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (n == 0)
                {
                    break;
                }

                if (flowerbed[i] == 0)
                {
                    bool back = (i == 0) || (flowerbed[i - 1] == 0);
                    bool front = (i == flowerbed.Length - 1) || (flowerbed[i+1] == 0);

                    if (back && front)
                    {
                        n--;
                        flowerbed[i] = 1;
                    }
                }
            }

            return n == 0;
        }
    }
}
