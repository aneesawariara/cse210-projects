using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator promptGenerator = new PromptGenerator();



    public void AddEntry()
    {
        
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

       _entries.Add(new Entry(prompt, response));
       
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in journal.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile(string file)
    {
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            
            _entries.Add(new Entry(prompt, response, date));
        }
        Console.WriteLine($"Journal reading from {filename}");
    }
}