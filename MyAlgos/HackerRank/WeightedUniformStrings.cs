namespace HackerRank;

internal class WeightedUniformStrings
{
    static void Main(string[] args)
    {
        const string s = "abbcccdddd";
        var queries = new List<int> { 1, 7, 5, 4, 15 };
        var result = weightedUniformStrings(s, queries);

        Console.WriteLine(result.ToString());
        Console.WriteLine("Press enter to close...");
        Console.ReadLine();
    }

    private static List<string> weightedUniformStrings(string s, List<int> queries)
    {
        var results = new List<string>();
        var alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
        var alphabetsWeighted = new Dictionary<char, int>();
        var weights = new Dictionary<string, int>();

        for (int i = 0; i < 26; i++)
        {
            alphabetsWeighted.Add(alphabets[i], i + 1);
        }

        for (int i = 0; i < s.Length; i++)
        {
            var lastKey = weights.Keys.LastOrDefault();
            if (lastKey?.EndsWith(s[i].ToString()) == true)
            {
                var lastWeight = weights[lastKey];
                lastKey += s[i].ToString();
                weights.Add(lastKey, lastWeight + alphabetsWeighted[s[i]]);
            }
            else
            {
                weights.Add(s[i].ToString(), alphabetsWeighted[s[i]]);
            }
        }

        foreach(var value in queries)
        {
            if (weights.ContainsValue(value))
            {
                results.Add("Yes");
            }
            else
            {
                results.Add("No");
            }
        }

        return results;
    }
}
