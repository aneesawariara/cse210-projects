using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    
    public Entry(string promptText, string entryText)
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        _promptText = promptText;
        _entryText = entryText;
    }

    public Entry(string promptText, string entryText, string date)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{_date}  {_promptText}: {_entryText}");
        
    }
}