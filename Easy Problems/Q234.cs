using LeetCode_Problems.Useful_LeetCode_Stuff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems
{
    /// <summary>
    /// 234. Palindrome Linked List
    /// 
    /// Given the head of a singly linked list, return true if it is a palindrome or false otherwise.
    /// 
    /// Example 1:
    /// Input: head = [1,2,2,1]
    /// Output: true
    /// 
    /// Example 2:
    /// Input: head = [1,2]
    /// Output: false
    /// </summary>
    internal class Q234
    {
        public bool IsPalindrome(ListNode head)
        {
            bool isPali = true;

            Stack ReverseNode = new Stack();
            Queue StraightNode = new Queue();
            ListNode currentNode = head;

            while (currentNode != null)
            {
                ReverseNode.Push(currentNode.val);
                StraightNode.Enqueue(currentNode.val);
                currentNode = currentNode.next;
            }

            while (ReverseNode.Count > 0)
            {
                if (ReverseNode.Peek().Equals(StraightNode.Peek()))
                {
                    ReverseNode.Pop();
                    StraightNode.Dequeue();
                }
                else
                {
                    return false;
                }
            }
            
            return isPali;
        }
    }
}
