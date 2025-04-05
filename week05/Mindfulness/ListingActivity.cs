using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity: Activity
{

    private int _count;
    private  string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the Holy Ghost this month? ",
        "Who are some of your personal heroes? "
    };

    public ListingActivity()
        :base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        ShowSpinner(5);

        


        
        Console.WriteLine("Starting the Listing Activity...");
        Console.WriteLine("Think about the following prompt and list as many items as you can!");

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");

        ShowCountDown(4);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> userList = GetListFromUser();

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Enter an item (or press Enter to finish):");
            string userInput = Console.ReadLine()?.Trim();

            
            if (string.IsNullOrEmpty(userInput))
            {
                break; 
            }
            else
            {
                userList.Add(userInput);
            }
        }
        
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items! Great Job!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);

        return _prompts[index];

    }

    public List<string> GetListFromUser()
    {
        Console.WriteLine("Enter items one by one. Press Enter without typing anything to finish.");

        List<string> userResponses = new List<string>();
        string userInput = "";

        while(userInput != "")
        {
            Console.WriteLine("Enter an item (or press Enter to finish):");
            userInput = Console.ReadLine()?.Trim();

            if (userInput.Trim() != "")
            {
                userResponses.Add(userInput);
            }
        }

        return userResponses;
    }
}