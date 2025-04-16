using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program.");

        GoalManager goalManager = new GoalManager();

        goalManager.Start();

        Console.WriteLine("Thank you for using the program! Goodbye!");
    }
}