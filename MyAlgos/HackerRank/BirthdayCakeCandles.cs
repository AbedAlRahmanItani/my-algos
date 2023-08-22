namespace HackerRank;

public class BirthdayCakeCandles
{
    //static void Main(string[] args)
    //{
    //    int[] myArray = new int[4];
    //    myArray = new[] { 3, 2, 1, 3 };

    //    int result = birthdayCakeCandles(myArray);

    //    Console.WriteLine("Result: " + result);

    //    Console.WriteLine();
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    static int birthdayCakeCandles(int[] ar)
    {
        int max = ar.Max();
        int result = 0;
        foreach (int item in ar)
        {
            if (item == max)
            {
                result++;
            }
        }
        return result;
    }
}
