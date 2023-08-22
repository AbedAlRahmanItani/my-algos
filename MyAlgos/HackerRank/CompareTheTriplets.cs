namespace HackerRank;

class CompareTheTriplets
{
    //static void Main(string[] args)
    //{
    //    List<int> a = new List<int> {17, 28, 30};
    //    List<int> b = new List<int> {99, 16, 8};

    //    List<int> resultList = CompareTriplets(a, b);
    //    Console.WriteLine("Result: " + resultList[0] + " " + resultList[1]);
    //}

    static List<int> CompareTriplets(List<int> a, List<int> b)
    {
        int alice = (a[0] > b[0] ? 1 : 0) + (a[1] > b[1] ? 1 : 0) + (a[2] > b[2] ? 1 : 0);
        int bob = (a[0] < b[0] ? 1 : 0) + (a[1] < b[1] ? 1 : 0) + (a[2] < b[2] ? 1 : 0);

        return new List<int> { alice, bob };

    }
}
