using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
       
        
        while (true)
        {
            Console.WriteLine("Welcome to your Journal!");
            Console.WriteLine("1. Write a new Entry");
            Console.WriteLine("2. Display Journal Entries");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal From File");
            Console.WriteLine("5. Quit");
            Console.Write("Please pick an action to do: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                theJournal.AddEntry();
            }

            else if (choice == "2")
            {
                theJournal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter the filename to save to: ");
                string saveFile = Console.ReadLine();
                theJournal.SaveToFile(saveFile);
            }

            else if (choice == "4")
            {
                Console.Write("Enter the filename to load from: ");
                string loadFile = Console.ReadLine();
                theJournal.LoadFromFile(loadFile);
            }

            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
        
    }
}