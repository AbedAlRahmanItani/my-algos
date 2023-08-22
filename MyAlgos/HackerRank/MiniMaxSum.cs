namespace HackerRank;

public class MiniMaxSum
{
    //static void Main(string[] args)
    //{
    //    int[] myArray = new int[5];
    //    myArray = new[] { 1,2,3,4,5 };

    //    miniMaxSum(myArray);

    //    Console.WriteLine();
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    static void miniMaxSum(int[] arr)
    {
        long sum = 0;
        int min = arr.Min();
        int max = arr.Max();
        foreach (int number in arr)
        {
            sum += number;
            if (min > number)
            {
                min = number;
            }
            if (max < number)
            {
                max = number;
            }
        }
        Console.WriteLine((sum - max) + " " + (sum - min));
    }
}
