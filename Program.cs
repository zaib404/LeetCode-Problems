using LeetCode_Problems.Medium_Problems;
using LeetCode_Problems.Useful_LeetCode_Stuff;
using LeetCode_Problems.Easy_Problems;

namespace LeetCode_Problems
{
    internal class Program
    {
        static OutputNodes outputNodes = new OutputNodes();
        static CreateLinkedList createLinkedLists = new CreateLinkedList();

        static void Main(string[] args)
        {

            Console.ReadLine();
        }

        static void ShipWithinDays()
        {
            //https://leetcode.com/problems/capacity-to-ship-packages-within-d-days/
        }

        static void AddTwoNumbers()
        {
            Q2 twoNums = new Q2();

            ListNode leftNode = createLinkedLists.AutomateLinkedLists(new int[] { 2, 4, 3 });
            ListNode rightNode = createLinkedLists.AutomateLinkedLists(new int[] { 5, 6, 4 });

            outputNodes.WriteNodes(twoNums.AddTwoNumbers(leftNode, rightNode));
        }

        static void TwoSum()
        {
            Q1 twoSum = new Q1();
            int[] nums = new int[] { 2, 7, 11, 15 };
            int[] ans = twoSum.TwoSum(nums, 9);
            ans.ToList().ForEach(Console.WriteLine);
        }

        static void RichCustomer()
        {
            Q1672 richCust = new Q1672();

            int[][] myDoubleArray = new int[4][];
            myDoubleArray[0] = new int[4] { 10, 10, 10, 10 };
            myDoubleArray[1] = new int[4] { 1, 1, 1, 1 };
            myDoubleArray[2] = new int[4] { 1, 1, 1, 2 };
            myDoubleArray[3] = new int[4] { 1, 1, 1, 3 };

            int a = richCust.MaximumWealth(myDoubleArray);

            Console.WriteLine(a);
        }

        static void NumOfSteps()
        {
            Q1342 numberOfSteps = new Q1342();
            int ans = numberOfSteps.NumberOfSteps(123);
            Console.WriteLine(ans);
        }

        static void KWeakRows()
        {
            Q1337 theKWeakestRowsInAMatrix = new Q1337();
            int[][] myDoubleArray = new int[4][];
            myDoubleArray[0] = new int[4] { 1, 0, 0, 0 };
            myDoubleArray[1] = new int[4] { 1, 1, 1, 1 };
            myDoubleArray[2] = new int[4] { 1, 0, 0, 0 };
            myDoubleArray[3] = new int[4] { 1, 0, 0, 0 };

            int[] ans = theKWeakestRowsInAMatrix.KWeakestRows(myDoubleArray, 2);

            ans.ToList().ForEach(Console.WriteLine);
        }

        static void MiddleLinked()
        {
            ListNode listNode = createLinkedLists.AutomateLinkedLists(new int[] { 1, 2, 3, 4, 5 });

            Q876 middle_Of_The_Linked_List = new Q876();
            ListNode node = middle_Of_The_Linked_List.MiddleNode(listNode);

            outputNodes.WriteNodes(node);

        }

        static void Fizz()
        {
            Q412 fizz_Buzz = new Q412();
            IList<string> list = fizz_Buzz.FizzBuzz(3);
            list.ToList().ForEach(Console.WriteLine);
        }

        static void Ransom()
        {
            Q383 ransomNote = new Q383();
            bool valueB = ransomNote.CanConstruct("abc", "cba");
            Console.WriteLine(valueB);
        }

        static void Roman()
        {
            Q13 romanToInteger = new Q13();
            int valueI = romanToInteger.RomanToInt("LXIX");
            Console.WriteLine(valueI);
        }
    }
}