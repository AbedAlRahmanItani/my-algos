namespace HackerRank;

class PlusMinus
{
    //static void Main(string[] args)
    //{
    //    int[] myArray = new int[6];
    //    myArray = new[] { -4, 3, -9, 0, 4, 1 };

    //    plusMinus(myArray);
    //}

    static void plusMinus(int[] arr)
    {
        double positive = (double)arr.Where(x => x > 0).Count() / arr.Length;
        Console.WriteLine("{0:0.000000}", positive);

        double negative = (double)arr.Where(x => x < 0).Count() / arr.Length;
        Console.WriteLine("{0:0.000000}", negative);

        double zeros = (double)arr.Where(x => x == 0).Count() / arr.Length;
        Console.WriteLine("{0:0.000000}", zeros);
    }
}
