namespace HackerRank;

class PickingNumbers
{
    //static void Main(string[] args)
    //{
    //    List<int> a = new List<int>
    //    {
    //        4, 6, 5, 3, 3, 1
    //    };
    //    //List<int> a = new List<int>
    //    //{
    //    //   1, 2, 2, 3, 1, 2
    //    //};
    //    //List<int> a = new List<int>
    //    //{
    //    //    66,66,66,66,66
    //    //};

    //    int res = pickingNumbers(a);

    //    Console.WriteLine(res.ToString());
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    public static int pickingNumbers(List<int> a)
    {
        List<int> counts = new List<int>();
        a = a.OrderBy(x => x).ToList();
        for (int i = 0; i < a.Count; i++)
        {
            List<int> subList = new List<int>();
            subList.Add(a[i]);
            for (int j = i + 1; j < a.Count; j++)
            {
                if (Math.Abs(a[i] - a[j]) <= 1)
                    subList.Add(a[j]);
            }

            counts.Add(subList.Count);
        }

        return counts.Max();
    }
}
