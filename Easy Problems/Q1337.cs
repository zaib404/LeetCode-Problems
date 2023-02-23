using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    /// <summary>
    /// 1337. The K Weakest Rows in a Matrix
    /// 
    /// You are given an m x n binary matrix mat of 1's (representing soldiers) and 0's (representing civilians). The soldiers are positioned in front of the civilians. That is, all the 1's will appear to the left of all the 0's in each row.
    /// 
    /// A row i is weaker than a row j if one of the following is true:
    /// 
    /// The number of soldiers in row i is less than the number of soldiers in row j.
    /// Both rows have the same number of soldiers and i<j.
    /// Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.
    /// 
    /// Example 1:
    /// Input: mat = 
    /// [[1,1,0,0,0],
    /// [1,1,1,1,0],
    /// [1,0,0,0,0],
    /// [1,1,0,0,0],
    /// [1,1,1,1,1]], 
    /// k = 3
    /// Output: [2,0,3]
    /// Explanation: 
    /// The number of soldiers in each row is: 
    /// - Row 0: 2 
    /// - Row 1: 4 
    /// - Row 2: 1 
    /// - Row 3: 2 
    /// - Row 4: 5 
    /// The rows ordered from weakest to strongest are[2, 0, 3, 1, 4].
    /// </summary>
    internal class Q1337
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < mat.Length; i++)
            {
                int oneCounter = 0;

                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        oneCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
                map.Add(i, oneCounter);
            }

            map = map.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            var returnIndex = map.Keys.ToList();
            returnIndex.RemoveRange(k, returnIndex.Count - k);

            return returnIndex.ToArray();
        }
    }
}
