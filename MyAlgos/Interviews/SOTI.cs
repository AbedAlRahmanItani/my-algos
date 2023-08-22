namespace Interviews
{
    class SOTI
    {
        //static void Main(string[] args)
        //{
        //    var list = new[] { 2, 1, 0, 2, 1, 1, 0, 1, 2, 1, 1, 0, 0, 2, 1 };

        //    var res = Oranges(3, 5, list.ToArray());

        //    Console.WriteLine(res.ToString());
        //    Console.WriteLine("Press enter to close...");
        //    Console.ReadLine();
        //}

        public static int Oranges(int input1, int input2, int[] input3)
        {
            int result = -1;
            int[,] array = new int[input1, input2];

            for (int i = 0; i < input1; i++)
            {
                for (int j = 0; j < input2; j++)
                {
                    array[i, j] = input3[i * input2 + j];
                }
            }

            for (int i = 0; i < input1; i++)
            {
                for (int j = 0; j < input2; j++)
                {
                    if (i == 0 && j == 0)
                    {

                    }
                }
            }

            return result;
        }
    }
}
