using System;

class Program
{
    static void Main(string[] args)
    {
        //Reference reference = new Reference("John", 3, 16);
        //Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life");
    
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());


            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            

            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            
            

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nCongratulations! You have memorized the verse.");
                break;

            }

        }
    
    
    }
}