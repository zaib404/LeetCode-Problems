using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Useful_LeetCode_Stuff
{
    internal class CreateLinkedList
    {
        /// <summary>
        /// Returns a LinkedLists by automating it so i dont have to spend a while writing it for different test cases
        /// </summary>
        /// <param name="pNodes">Takes an int array as input to represent the nodes</param>
        /// <returns></returns>
        public ListNode AutomateLinkedLists(int[] pNodes)
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
    }
}
