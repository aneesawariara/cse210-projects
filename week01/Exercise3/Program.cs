using System;

class Program
{
    static void Main(string[] args)
    {
        

        Console.Write("What is the magic number? ");

        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);

        

        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);
            
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
    }
}