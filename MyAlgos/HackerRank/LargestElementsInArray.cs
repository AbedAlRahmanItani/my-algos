namespace HackerRank;

class LargestElementsInArray
{
    //static void Main(string[] args)
    //{
    //    List<int> elements = new List<int>
    //    {
    //        1, 23, 12, 9, 30, 2, 50
    //    };

    //    var res = GetLargestElements(elements, 3);

    //    Console.WriteLine(res.ToString());
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    public static List<int> GetLargestElements(List<int> elements, int k)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < k; i++)
        {
            int max = elements.Max();
            elements.Remove(max);
            result.Add(max);
        }
        return result;
    }

    // OR
    public static List<int> GetLargestElements(int[] elements, int k)
    {
        List<int> result = new List<int>();

        Array.Sort(elements);
        Array.Reverse(elements);

        for (int i = 0; i < k; i++)
            result.Add(elements[i]);
        
        return result;
    }
}
