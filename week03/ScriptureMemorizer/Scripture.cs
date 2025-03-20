using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        
        
        while (hiddenCount < numberToHide)
        {
            if (IsCompletelyHidden())
            {
                break;
            }
            
            int index = random.Next(_words.Count);
            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
                hiddenCount = hiddenCount + 1;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            string wordDisplayText = word.GetDisplayText();
            displayText = displayText + wordDisplayText + ' ';
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
} 