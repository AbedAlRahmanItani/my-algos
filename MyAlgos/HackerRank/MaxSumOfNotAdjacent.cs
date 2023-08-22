namespace HackerRank;

class MaxSumOfNotAdjacent
{
    //static void Main(string[] args)
    //{
    //    int[] a = new int[] { 1, 20, 3 };

    //    var res = SumNotAdjacent(a);

    //    Console.WriteLine(res.ToString());
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    static int SumNotAdjacent(int[] a)
    {
        int sumOdd = 0;
        int SumEven = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (i % 2 == 0)
                sumOdd += a[i];
            else
                SumEven += a[i];
        }

        return sumOdd > SumEven ? sumOdd : SumEven;
    }
}
