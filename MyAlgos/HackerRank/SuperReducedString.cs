namespace HackerRank;

internal class SuperReducedString
{
    //static void Main(string[] args)
    //{
    //    var result = superReducedString("aaabccddd");

    //    Console.WriteLine(result.ToString());
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    //public static string superReducedString(string s)
    //{
    //    var result = string.Empty;
    //    var charsCountDico = new Dictionary<char, int>();

    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        if (charsCountDico.ContainsKey(s[i]))
    //        {
    //            charsCountDico[s[i]]++;
    //        }
    //        else
    //        {
    //            charsCountDico.Add(s[i], 1);
    //        }
    //    }

    //    foreach (var kvp in charsCountDico)
    //    {
    //        if (kvp.Value % 2 != 0)
    //        {
    //            result += kvp.Key;
    //        }
    //    }

    //    return result == string.Empty ? "Empty String" : result;
    //}

    public static string superReducedString(string s)
    {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Count > 0 && s[i] == stack.Peek())
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
            }
        }

        var result = new string(stack.Reverse().ToArray());

        return result == string.Empty ? "Empty String" : result;
    }
}
