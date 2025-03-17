using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
        public List<string> _randomPrompt = new List<string>();
    
        
        public PromptGenerator()
        {
            _randomPrompt.Add("Who was the most interesting person I interacted with today?");
            _randomPrompt.Add("What was the best part of my day?");
            _randomPrompt.Add("How did I see the hand of the Lord in my life today?");
            _randomPrompt.Add("What was the strongest emotion I felt today?");
            _randomPrompt.Add("If I had one thing I could do over today, what would it be?");
        }
         
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_randomPrompt.Count);
        
        return _randomPrompt[index];
    } 
}