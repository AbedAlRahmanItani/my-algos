namespace HackerRank;

class DeterminingDnaHealth
{
    //static void Main(string[] args)
    //{
    //    int n = 6;
    //    string[] genes = new string[]
    //    {
    //        "a", "b", "c", "aa", "d", "b"
    //    };

    //    int[] health = new int[]
    //    {
    //        1, 2, 3, 4, 5, 6
    //    };

    //    int s = 3;

    //    List<DnaSearchParam> dnaSearchParams = new List<DnaSearchParam>
    //    {
    //        new DnaSearchParam
    //        {
    //            First = 1,
    //            Last= 5,
    //            Dna = "caaab"
    //        },
    //        new DnaSearchParam
    //        {
    //            First = 0,
    //            Last= 4,
    //            Dna = "xyz"
    //        },
    //        new DnaSearchParam
    //        {
    //            First = 2,
    //            Last= 4,
    //            Dna = "bcdybc"
    //        }
    //    };

    //    DetermineDnaHealth(n, genes, health, dnaSearchParams);

    //    Console.WriteLine();
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}
    
    public static void DetermineDnaHealth(int n, string[] genes, int[] health, List<DnaSearchParam> dnaSearchParams)
    {
        //foreach(var item in dnaSearchParams)
        //{
        //    List<char> dnaChars = item.Dna.ToList();
        //    List<string> combinations = new List<string>();
        //    int maxComb = dnaChars.Count;
        //    for(int i = 0; i < maxComb; i++)
        //    {
        //        string comb = "";
        //        foreach (var dc in dnaChars)
        //        {
        //            comb
        //        }
        //    }



        //}

        Dictionary<string, int> dict = new Dictionary<string, int>();
        //    var keyOfMaxValue = dict.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        //var x= dict.Keys.La

        //          var maxValue = candidateVotes.Values.Max();
        //Dictionary<string, int> candidateWithMaxVotes = new Dictionary<string, int>();
        //foreach (var item in candidateVotes.Values.Where(x => x == maxValue))
        //{
        //    candidateWithMaxVotes.Add(item.Key, item.Value);
        //}

        var max = from x in dict where x.Value == dict.Max(v => v.Value) select x.Key;
        max.OrderBy(x=>x).Last();
    }

    public class DnaSearchParam
    {
        public int First { get; set; }
        public int Last { get; set; }
        public string Dna { get; set; }
    }
}
