namespace LeetCode;

internal class CoinChange
{
    static void Main(string[] args)
    {
        // Expected = 3
        var coins = new[] { 1, 2, 5 };
        var amount = 11;
        var result = ChangeCoin(coins, amount);
        Console.WriteLine(result.ToString());

        // Expected = -1
        coins = new[] { 2 };
        amount = 3;
        result = ChangeCoin(coins, amount);
        Console.WriteLine(result.ToString());

        Console.WriteLine("Press enter to close...");
        Console.ReadLine();
    }

    private static int ChangeCoin(int[] coins, int amount)
    {
        var count = 0;
        var remainingAmount = amount;
        foreach (var coin in coins.OrderByDescending(x => x))
        {
            while (remainingAmount >= coin)
            {
                remainingAmount -= coin;
                count++;
            }
        }

        return count;
    }
}