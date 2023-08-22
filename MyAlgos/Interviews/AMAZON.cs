namespace Interviews
{
    class AMAZON
    {
        //static void Main(string[] args)
        //{
        //    List<int> a = new List<int> { 5, 1, 4, 2 };
        //    //List<int> a = new List<int> { 2, 7, 12 };

        //    var res = howManySwaps(a);

        //    Console.WriteLine(res.ToString());
        //    Console.WriteLine("Press enter to close...");
        //    Console.ReadLine();
        //}

        //public static long howManySwaps(List<int> arr)
        //{
        //    long swapCount = 0;
        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        for (int j = i + 1; j < arr.Count; j++)
        //        {
        //            if (arr[i] > arr[j])
        //                swapCount++;
        //        }
        //    }
        //    return swapCount;
        //}

        public static long howManySwaps(List<int> arr)
        {
            long swapCount = 0;
            var sortedArr = arr.OrderBy(x => x).ToList();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > sortedArr[i])
                    swapCount++;
            }
            return swapCount;
        }

        //https://www.geeksforgeeks.org/check-if-a-given-sequence-of-moves-for-a-robot-is-circular-or-not/
        public static List<string> doesCircleExist(List<string> commands)
        {
            var result = new List<string>();

            foreach (string command in commands)
            {
                int xAxis = 0;
                int yAxis = 0;
                int direction = 0;

                for (int i = 0; i < command.Length; i++)
                {
                    var step = command[i];
                    if (step == 'R')
                        direction = (direction + 1) % 4;
                    else if (step == 'L')
                        direction = (4 + direction - 1) % 4;
                    else
                    {
                        if (direction == 0)
                            yAxis++;
                        else if (direction == 1)
                            xAxis++;
                        else if (direction == 2)
                            yAxis--;
                        else
                            xAxis--;
                    }
                }

                if (xAxis == 0 && yAxis == 0)
                    result.Add("YES");
                else
                    result.Add("NO");
            }

            return result;
        }
    }
}
