namespace HackerRank;

internal class SherlockAndTheValidString
{
    //static void Main(string[] args)
    //{
    //    var result = IsValid("aaaaaa");

    //    Console.WriteLine(result.ToString());
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    /// <summary>
    /// Sherlock and the Valid String
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static string IsValid(string s)
    {
        var dico = new Dictionary<char, int>();
        foreach (var c in s.ToCharArray())
        {
            if (!dico.ContainsKey(c))
            {
                dico.Add(c, 1);
            }
            else
            {
                dico[c]++;
            }
        }

        if (dico.Count == 1)
            return "YES";

        int[] values = dico.Values.OrderBy(x => x).ToArray();

        int first = values[0];
        int second = values[1];
        int beforeLast = values[values.Length - 2];
        int last = values[values.Length - 1];

        // If first and last are same, then all frequencies are same
        if (first == last)
            return "YES";

        // If first is 1, and all other characters have 1 frequency
        if (first == 1 && second == last)
            return "YES";

        // If all are same and last character has just 1 extra count
        if (first == second && second == beforeLast && beforeLast == (last - 1))
            return "YES";

        return "NO";
    }
}

