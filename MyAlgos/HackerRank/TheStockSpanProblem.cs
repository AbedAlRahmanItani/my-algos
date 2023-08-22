namespace HackerRank;

class TheStockSpanProblem
{
    //The stock span problem is a financial problem where we have a series of n daily price quotes for a stock and we need to calculate span of stock’s price for all n days.
    //The span Si of the stock’s price on a given day i is defined as the maximum number of consecutive days just before the given day, for which the price of the stock on the current day is less than or equal to its price on the given day.
    //For example, if an array of 7 days prices is given as {100, 80, 60, 70, 60, 75, 85}, then the span values for corresponding 7 days are {1, 1, 1, 2, 1, 4, 6}

    //static void Main(string[] args)
    //{
    //    List<int> prices = new List<int>
    //    {
    //        100, 80, 60, 70, 60, 75, 85
    //    };

    //    var res = GetStockSpan(prices);

    //    Console.WriteLine(res.ToString());
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    public static List<int> GetStockSpan(List<int> prices)
    {
        List<int> result = new List<int>();
        for(int i = 0; i < prices.Count; i++)
        {
            int count = 1;
            for(int j = i - 1; j >= 0; j--)
            {
                if (prices[i] >= prices[j])
                    count++;
                else
                    break;
            }
            result.Add(count);
        }
        return result;
    }
}
