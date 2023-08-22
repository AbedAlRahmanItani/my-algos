namespace HackerRank;

public class TimeConversion
{
    //static void Main(string[] args)
    //{
    //    string time = "11:05:45PM";

    //    string result = timeConversion(time);

    //    Console.WriteLine("Result: " + result);

    //    Console.WriteLine();
    //    Console.WriteLine("Press enter to close...");
    //    Console.ReadLine();
    //}

    public static string timeConversion(string s)
    {
        string[] timeParts = s.Remove(s.Length - 2).Split(':');
        string hour = timeParts[0];
        string minute = timeParts[1];
        string second = timeParts[2];

        if (s.EndsWith("AM"))
        {
            if (Convert.ToInt32(hour) == 12)
                hour = "00";
        }
        else
        {
            if (Convert.ToInt32(hour) >= 1 && Convert.ToInt32(hour) <= 11)
                hour = (12 + Convert.ToInt32(hour)).ToString().PadLeft(2, '0');
        }
         
        return string.Format("{0}:{1}:{2}", hour, minute, second);
    }
}
