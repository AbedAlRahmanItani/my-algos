namespace HackerRank;

class NextGreaterElement
{
    //Given an array, print the Next Greater Element (NGE) for every element. The Next greater Element for an element x is the first greater element on the right side of x in the array. Elements for which no greater element exist, consider next greater element as -1. 

    //static void Main(string[] args)
    //{
    //    List<int> elements = new List<int>
    //    {
    //        13, 7, 6, 12
    //    };

    //    var res = GetNextGreaterElement(elements);

    //    Console.WriteLine(res.ToString());
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    public static List<int> GetNextGreaterElement(List<int> elements)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < elements.Count; i++)
        {
            int nge = -1;
            for (int j = i + 1; j < elements.Count; j++)
            {
                if (elements[i] < elements[j])
                {
                    nge = elements[j];
                    break;
                }
            }
            result.Add(nge);
        }
        return result;
    }
}
