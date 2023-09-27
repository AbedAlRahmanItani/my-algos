namespace HackerRank;

internal class MakingAnagrams
{
    //static void Main(string[] args)
    //{
    //    var result = MakeAnagram("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke");

    //    Console.WriteLine(result.ToString());
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    public static int MakeAnagram(string a, string b)
    {
        var dico = new Dictionary<char, int>();
        foreach (var c in a.ToCharArray())
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
        foreach (var c in b.ToCharArray())
        {
            if (!dico.ContainsKey(c))
            {
                dico.Add(c, -1);
            }
            else
            {
                dico[c]--;
            }
        }

        return dico.Values.Sum(x => Math.Abs(x));
    }
}