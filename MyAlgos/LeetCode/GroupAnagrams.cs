namespace LeetCode;

internal class GroupAnagrams
{
    //static void Main(string[] args)
    //{
    //    var strs = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };
    //    var result = GroupAnagram(strs);

    //    Console.WriteLine(result.ToString());
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    public static IList<IList<string>> GroupAnagram(string[] strs)
    {
        var dico = new Dictionary<string, IList<string>>();
        foreach (var str in strs)
        {
            var sortedStr = string.Concat(str.OrderBy(c => c));
            if (!dico.ContainsKey(sortedStr))
            {
                dico.Add(sortedStr, new List<string> { str });
            }
            else
            {
                dico[sortedStr].Add(str);
            }
        }

        return dico.Values.ToList();
    }
}
