namespace Interviews
{
    class REPAY
    {
        static void Main(string[] args)
        {
            //var res = solution(670);
            var res = removeDefective("header,header\nANNUL,ANNULLED\nnull,NILL\nNULL,NULL");

            Console.WriteLine(res.ToString());
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public static int solution(int N)
        {
            var stringN = N.ToString();
            var max = int.MinValue;

            for (int i = N < 0 ? 1 : 0; i <= stringN.Length; ++i)
            {
                var value = int.Parse(stringN.Insert(i, "5"));
                if (max < value)
                    max = value;
            }

            return max;
        }

        public static string removeDefective(string S)
        {
            string result = "";
            string[] lines = S.Split(new string[] { "\n" }, StringSplitOptions.None);

            result += lines[0] + "\n";
            for (int i = 1; i < lines.Length; i++)
            {
                if (!lines[i].Contains("NULL,") && !lines[i].Contains(",NULL") && !lines[i].Contains(",NULL,"))
                {
                    result += lines[i] + "\n";
                }
            }
            if (result.EndsWith("\n"))
                result = result.Substring(0, result.Length - 1);

            return result;
        }

        public class Row
        {
            public string Cell { get; set; }
        }
    }
}
