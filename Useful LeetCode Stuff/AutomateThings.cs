using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Useful_LeetCode_Stuff
{
    internal class AutomateThings
    {
        /// <summary>
        /// Returns a LinkedLists by automating it so i dont have to spend a while writing it for different test cases
        /// </summary>
        /// <param name="pNodes">Takes an int array as input to represent the nodes</param>
        /// <returns></returns>
        public ListNode AutomateListNodes(int[] pNodes)
        {
            // current is used to create new nodes and head is used to keep track of the first node
            ListNode current = null;
            ListNode head = null;

            // for loop so it will create the linked lists
            for (int i = 0; i < pNodes.Length; i++)
            {
                // if current is null make a new ListNode
                if (current == null)
                {
                    current = new ListNode();
                }
                // set the val for the current node for the first value
                current.val = pNodes[i];

                // if head is null then assign the value of current to it.
                if (head == null)
                {
                    head = current;
                }

                // as long as it isnt the last node 
                if (i < pNodes.Length - 1)
                {
                    // assign next as a new ListNode then update current to the new one
                    current.next = new ListNode();
                    current = current.next;
                }
            }

            return head;
        }

        /// <summary>
        /// Automate the TreeNode. ChatGPT rewrote this code. so it could display it how i wanted it to.
        /// </summary>
        /// <param name="pRoots"></param>
        /// <returns></returns>
        public TreeNode AutomateBinaryTree(int?[] pRoots)
        {
            // check if null or empty
            if (pRoots == null || pRoots.Length == 0)
            {
                return null;
            }

            TreeNode root = new TreeNode(pRoots[0] ?? 0);

            int index = 1;

            // Initialize a queue to keep track of the nodes to be processed
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (index < pRoots.Length && queue.Count > 0)
            {
                // Dequeue the next node from the queue
                TreeNode node = queue.Dequeue();

                // Check if the left child node should be added
                if (pRoots[index] != null)
                {
                    // Create a new TreeNode with the value at the current index in the input array and set left child to new node
                    node.left = new TreeNode(pRoots[index].Value);
                    // Enqueue the new node to the queue for further processing
                    queue.Enqueue(node.left);
                }
                // Increment the index variable to move to the next element in the input array
                index++;

                // Check if the right child node should be added
                if (index < pRoots.Length && pRoots[index] != null)
                {
                    node.right = new TreeNode(pRoots[index].Value);
                    queue.Enqueue(node.right);
                }

                index++;
            }

            return root;
        }

        #region my first attempt

        //for (int i = 1; i < pRoots.Length; i++)
        //{
        //    // Create new node with the current Value in the array
        //    TreeNode node = new TreeNode(pRoots[i]);

        //    // make a temp treeNode to help traverse inside while loop
        //    TreeNode temp = root;

        //    while (true)
        //    {
        //        // left side check. Check if the new value is less than the current nodes value.
        //        if (node.val < temp.val)
        //        {
        //            // if left child is null then set it as its new node and break out
        //            if (temp.left == null)
        //            {
        //                temp.left = node;
        //                break;
        //            }
        //            else
        //            {
        //                // else set the current node to be its left child and continue the loop
        //                temp = temp.left;
        //            }
        //        }
        //        // right side check
        //        else if (node.val >= temp.val)
        //        {
        //            if (temp.right == null)
        //            {
        //                temp.right = node;
        //                break;
        //            }
        //            else
        //            {
        //                temp = temp.right;
        //            }
        //        }
        //    }
        //    root = temp;
        //}

        //return root;

        #endregion
    }
}
