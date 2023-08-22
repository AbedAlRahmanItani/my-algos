namespace HackerRank;

class AVeryBigSum
{
    //static void Main(string[] args)
    //{
    //    List<long> numbers = new List<long> { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

    //    long result = aVeryBigSum(numbers.ToArray());
    //    Console.WriteLine("Result: " + result);
    //}

    static long aVeryBigSum(long[] ar)
    {
        return ar.Sum(x => x);
    }
}
