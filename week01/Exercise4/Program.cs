using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            
            Console.Write("Eneter number: ");
            string userResponse= Console.ReadLine();
            userNumber = int.Parse(userResponse);
            

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max number is: {max}");
    }
}