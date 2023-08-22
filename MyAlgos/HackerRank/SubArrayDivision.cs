namespace HackerRank;

public class SubArrayDivision
{
    //static void Main(string[] args)
    //{
    //    var list = new List<int> { 1, 2, 1, 3, 2 };

    //    int result = birthday(list, 3, 2);

    //    Console.WriteLine("Result: " + result);

    //    Console.WriteLine();
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    static int birthday(List<int> s, int d, int m)
    {
        int segCount = 0;
        for (int i = 0; i < s.Count; i++)
        {
            int sum = s[i];
            int count = 0;
            for (int j = i; j < s.Count; j++)
            {
                sum += s[j];
                count++;
                if(sum == d || count == m)
                {
                    segCount++;
                }
            }
        }
        return segCount;
    }
}
