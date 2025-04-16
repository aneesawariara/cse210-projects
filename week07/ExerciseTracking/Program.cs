using System;

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = {
            new Running("16 Apr 2025", 45, 3.0),
            new Cycling("16 Apr 2025", 39, 9.7),
            new Swimming("16 Apr 2025", 28, 20)
        };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}