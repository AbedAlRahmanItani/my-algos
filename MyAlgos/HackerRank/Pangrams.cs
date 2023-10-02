namespace HackerRank;

internal class Pangrams
{
    //static void Main(string[] args)
    //{
    //    // pangram
    //    var result = pangrams("We promptly judged antique ivory buckles for the next prize");
    //    Console.WriteLine(result.ToString());

    //    // not pangram
    //    result = pangrams("We promptly judged antique ivory buckles for the prize");
    //    Console.WriteLine(result.ToString());

    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    private static string pangrams(string s)
    {
        const int numberOfEnglishLetters = 26;
        var result = new HashSet<char>();

        foreach (char c in s.ToLower())
        {
            if(c != ' ')
            {
                result.Add(c);
            }
        }

        return result.Count == numberOfEnglishLetters
            ? "pangram"
            : "not pangram";
    }
}
