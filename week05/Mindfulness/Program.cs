using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindflness Program!");
            Console.WriteLine("Please select an activity");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Your choice: ");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (userChoice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (userChoice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (userChoice == "4")
            {
                isRunning = false;
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                Thread.Sleep(2000);
            }
            
        }
    }
}