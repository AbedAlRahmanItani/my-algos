namespace HackerRank;

class DiagonalDifference
{
    //static void Main(string[] args)
    //{
    //    int[][] myArray = new int[3][];
    //    myArray[0] = new[] { 1, 2, 3 };
    //    myArray[1] = new[] { 4, 5, 6 };
    //    myArray[2] = new[] { 9, 8, 9 };

    //    int result = diagonalDifference(myArray);
    //    Console.WriteLine("Result: " + result);
    //}

    static int diagonalDifference(int[][] arr)
    {
        int sumOfLeftToRight = 0, sumOfRightToLeft = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i == j)
                {
                    sumOfLeftToRight += arr[i][j];
                }
            }
            for (int j = arr.Length - 1; j >= 0; j--)
            {
                if (arr.Length - 1 - i == j)
                {
                    sumOfRightToLeft += arr[i][j];
                }
            }
        }

        return Math.Abs(sumOfLeftToRight - sumOfRightToLeft);
    }
}
