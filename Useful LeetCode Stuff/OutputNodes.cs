using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode_Problems.Useful_LeetCode_Stuff
{
    internal class OutputNodes
    {
        public void WriteNodes(ListNode pNodes)
        {
            string ans = "";
            while (pNodes != null)
            {
                ans += pNodes.val + " ";
                pNodes = pNodes.next;
            }
            Console.WriteLine(ans);
        }
    }
}
