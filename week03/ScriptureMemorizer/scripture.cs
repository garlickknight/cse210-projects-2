using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture2
{
    private static Random random = new Random();
    private List<Word2> _words = new List<Word2>();
    private Reference2 _reference;

    public Scripture2(Reference2 reference, string verse)
    {
        _reference = reference;
        string[] words = verse.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word2(word));
        }

    }

    public string GetDesplayText()
    {
        string displayText = _reference.GetDesplayText() + " ";
        foreach (Word2 word in _words)
        {
            displayText += word.GetDesplayText() + " ";
        }
        return displayText.Trim();

    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word2> Vwords = _words.Where(w => !w.IsHidden()).ToList();
        int HideWords = Math.Min(numberToHide, Vwords.Count);
        for (int i = 0; i < HideWords; i++)
        {
            int randomIndex = random.Next(Vwords.Count);
            Vwords[randomIndex].Hide();
            Vwords.RemoveAt(randomIndex); // AI helped here
        }

    }
    public bool IsCompletelyHidden() // I left this out and AI helped me relize I needed put something like this in my code. 
    {
        return _words.All(w => w.IsHidden());
    }


}