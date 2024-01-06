using System;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        // Initialize minPrice to the highest possible value and maxProfit to 0
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        // Iterate through each price in the array
        foreach (int price in prices)
        {
            // Update minPrice if the current price is lower
            if (price < minPrice)
            {
                minPrice = price;
            }
            // Update maxProfit if the current profit is greater than the previous maxProfit
            else if (price - minPrice > maxProfit)
            {
                maxProfit = price - minPrice;
            }
        }

        return maxProfit;
    }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of the Solution class
        var solution = new Solution();

        // Test case 1
        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine($"Max Profit for prices1: {solution.MaxProfit(prices1)}"); // Expected: 5

        // Test case 2
        int[] prices2 = { 7, 6, 4, 3, 1 };
        Console.WriteLine($"Max Profit for prices2: {solution.MaxProfit(prices2)}"); // Expected: 0
    }
}
