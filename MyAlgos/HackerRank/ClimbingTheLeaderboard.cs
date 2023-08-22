namespace HackerRank;

class ClimbingTheLeaderboard
{
    //static void Main(string[] args)
    //{
    //    int[] scores = new[] { 100, 100, 50, 40, 40, 20, 10 };
    //    int[] alice = new[] { 5, 25, 50, 120 };

    //    int[] result = climbingLeaderboard(scores, alice);
    //    foreach (var item in result)
    //        Console.WriteLine(item);

    //    Console.WriteLine();
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    static int[] climbingLeaderboard(int[] scores, int[] alice)
    {
        Dictionary<int, int> allRanks = new Dictionary<int, int>();
        List<int> aliceRanks = new List<int>();

        List<int> distinctScores = scores.Distinct().ToList();
        for (int i = 0; i < distinctScores.Count; i++)
        {
            if (!allRanks.ContainsKey(i + 1))
                allRanks.Add(i + 1, distinctScores[i]);
        }

        for (int i = 0; i < alice.Length; i++)
        {
            int minScore = allRanks.Values.Min();
            if (alice[i] < minScore)
            {
                int maxRank = allRanks.Keys.Max();
                aliceRanks.Add(maxRank + 1);
                continue;
            }

            int maxScore = allRanks.Values.Max();
            if (alice[i] >= maxScore)
            {
                int minRank = allRanks.Keys.Min();
                aliceRanks.Add(minRank);
                continue;
            }

            for (int j = 0; j < allRanks.Count; j++)
            {
                if (alice[i] > allRanks[j + 1])
                {
                    aliceRanks.Add(j + 1);
                }
            }
        }

        return aliceRanks.ToArray();
    }
}
