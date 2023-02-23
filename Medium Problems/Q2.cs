using LeetCode_Problems.Useful_LeetCode_Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Medium_Problems
{
    /// <summary>
    /// 2. Add Two Numbers
    /// 
    /// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
    /// 
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    /// 
    /// Example 1:
    /// Input: l1 = [2,4,3], l2 = [5,6,4]
    /// Output: [7,0,8]
    /// Explanation: 342 + 465 = 807.
    /// </summary>
    internal class Q2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> num1 = new List<int>();
            List<int> num2 = new List<int>();

            ListNode head = l1;

            while (head != null)
            {
                num1.Insert(0, head.val);
                head = head.next;
            }

            head = l2;

            while (head != null)
            {
                num2.Insert(0, head.val);
                head = head.next;
            }

            int digitsMissing = Math.Abs(num1.Count - num2.Count);

            for (int i = 0; i < digitsMissing; i++)
            {
                if (num1.Count < num2.Count)
                {
                    num1.Insert(0, 0);
                }
                else
                {
                    num2.Insert(0, 0);
                }
            }


            int carry = 0;

            string value = string.Empty;

            for (int i = num1.Count - 1; i >= 0; i--)
            {
                int sum = num1[i] + num2[i] + carry;
                carry = sum / 10;

                if (i != 0)
                {
                    sum %= 10;
                }

                value = value.Insert(0, sum.ToString());
            }

            ListNode returnNode = new ListNode();
            returnNode.val = int.Parse(value[value.Length - 1].ToString());

            if (value.Length > 1)
            {
                head = new ListNode();
                returnNode.next = head;

                for (int i = value.Length - 2; i >= 0; i--)
                {
                    head.val = int.Parse(value[i].ToString());

                    if (i != 0)
                    {
                        ListNode cur = new ListNode();
                        head.next = cur;
                        head = cur;
                    }
                }
            }

            return returnNode;
        }
    }
}
