using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LeetCode_Problems.Easy_Problems
{
    /// <summary>
    /// 121. Best Time to Buy and Sell Stock
    /// 
    /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
    /// 
    /// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    /// 
    /// Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
    /// 
    /// Example 1:
    /// Input: prices = [7, 1, 5, 3, 6, 4]
    /// Output: 5
    /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
    /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
    /// 
    /// Example 2:
    /// Input: prices = [7,6,4,3,1]
    /// Output: 0
    /// Explanation: In this case, no transactions are done and the max profit = 0.
    /// </summary>
    internal class Q121
    {
        public int MaxProfit(int[] prices)
        {
            #region Approach 1 Time Limit Exceeded

            //// Set initial values for buyPrice, sellPrice, and maxProfit.
            //// buyPrice is set to the maximum possible value to ensure that the first price encountered will be less than buyPrice.
            //// sellPrice, profit, and maxProfit are all initially set to 0.
            //int buyPrice = int.MaxValue;
            //int sellPrice = 0;
            //int profit = 0;
            //int maxProfit = 0;

            //// Loop through the prices array from the first element to the last element.
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    // Set the buy price to the current element.
            //    buyPrice = prices[i];

            //    // Loop through the prices array from the current element to the last element.
            //    for (int j = i + 1; j < prices.Length; j++)
            //    {
            //        // Set the sell price to the current element.
            //        sellPrice = prices[j];

            //        // If the buy price is less than the sell price, calculate the profit.
            //        if (buyPrice < sellPrice)
            //        {
            //            // If the current profit is greater than the current maximum profit, update the maximum profit.
            //            profit = sellPrice - buyPrice;

            //            if (profit > maxProfit)
            //            {
            //                maxProfit = profit;
            //            }
            //        }

            //    }
            //}

            //return maxProfit;

            #endregion


            #region Approach 2

            // set the minPrice to first element
            int minPrice = prices[0];
            int maxProfit = 0;

            // loop through all the prices element starting at index 1
            for (int i = 1; i < prices.Length; i++)
            {
                // set the currentPrice to current value in loop
                int currentPrice = prices[i];
                // calcualte profit if you was to sell on this day
                int currentProfit = currentPrice - minPrice;

                // check if currentProfit is greater than maxProfit
                if (currentProfit > maxProfit)
                {
                    // set new value for max
                    maxProfit = currentProfit;
                }
                // check if its less than minPrice
                // 1 < 7
                if (currentPrice < minPrice)
                {
                    minPrice = currentPrice;
                }
            }

            return maxProfit;

            #endregion
        }
    }
}
