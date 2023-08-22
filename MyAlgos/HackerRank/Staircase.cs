namespace HackerRank;

class Staircase
{
    //static void Main(string[] args)
    //{
    //    int n = 4;
    //    staircase(n);

    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    static void staircase(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(i + j < n - 1 ? " " : "#");
            }
            Console.WriteLine();
        }
    }
}
