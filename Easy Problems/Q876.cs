using LeetCode_Problems.Useful_LeetCode_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode_Problems
{
    /// <summary>
    /// 876. Middle of the Linked List
    /// 
    /// Given the head of a singly linked list, return the middle node of the linked list.
    /// 
    /// If there are two middle nodes, return the second middle node.
    /// 
    /// Example 1:
    /// Input: head = [1,2,3,4,5]
    /// Output: [3,4,5]
    /// Explanation: The middle node of the list is node 3.
    /// </summary>
    internal class Q876
    {
        public ListNode MiddleNode(ListNode head)
        {
            // store empty node 
            ListNode returnNode = new ListNode();
            // store the current node its on
            ListNode current = head;
            // count how many nodes its got
            double counter = 0;
            double halfPoint = 0;

            // loop through the nodes and count 
            while (current != null)
            {
                counter++;

                current = current.next;
            }

            halfPoint = counter % 2 == 0 ? (counter / 2) + 1 : Math.Round(counter / 2, MidpointRounding.AwayFromZero);

            counter = 0;

            // loop again starting from the counter.
            while (head != null)
            {
                counter++;

                if (counter == halfPoint)
                {
                    returnNode.val = head.val;
                    returnNode.next = head.next;
                    break;
                }

                head = head.next;
            }

            return returnNode;
        }
    }
}
