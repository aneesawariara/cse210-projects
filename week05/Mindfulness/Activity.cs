public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} Activity.");
        Console.WriteLine(_description);
        Console.WriteLine("Enter the duration for this activity(in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Duration set to {_duration} seconds.");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great Job!");
        Console.WriteLine($"You have completed {_name} Activity");
        ShowSpinner(3);

    }

    public void ShowSpinner(int seconds)
    {
        
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
            
        }
    }

    public void ShowCountDown(int seconds)
    {
        Console.WriteLine("Counting down...");
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }

        Console.WriteLine("Begin!\n");

    }
}
