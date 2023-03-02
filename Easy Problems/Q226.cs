using LeetCode_Problems.Useful_LeetCode_Stuff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Easy_Problems
{
    /// <summary>
    /// 226. Invert Binary Tree
    /// Given the root of a binary tree, invert the tree, and return its root.
    /// 
    /// Example 1:
    /// Input: root = [4, 2, 7, 1, 3, 6, 9]
    /// Output: [4,7,2,9,6,3,1]
    /// 
    /// Example 2:
    /// Input: root = [2, 1, 3]
    /// Output: [2,3,1]
    /// 
    /// Example 3:
    /// Input: root = []
    /// Output: []
    /// 
    /// Constraints:
    /// The number of nodes in the tree is in the range [0, 100].
    /// -100 <= Node.val <= 100
    /// </summary>
    internal class Q226
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode right = InvertTree(root.right);
            TreeNode left = InvertTree(root.left);
            root.left = right;
            root.right = left;

            return root;
        }
    }
}
