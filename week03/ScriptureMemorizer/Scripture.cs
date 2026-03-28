using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<string> texts = text.Split(" ").ToList();
        List<Word> words = new List<Word>();
        foreach (string i in texts)
        {
            Word word = new Word(i);
            words.Add(word);
        }
        _words = words;
    }

    public void HideRandomWords(int numberToHide)
    {
        _words[numberToHide].Hide();
    }

    public bool GetHiddenStatus(int indexNumber)
    {
        return _words[indexNumber].IsHidden();
    }

    public string GetDisplayText()
    {
        List<string> texts = new List<string>();
        foreach (Word word in _words)
        {
            texts.Add(word.GetDisplayText());
        }
        
        string text = String.Join(" ", texts);

        return text;
    }

    public bool IsCompletelyHidden()
    {
        int totalHidden = 0;
        int totalCount = _words.Count();

        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                totalHidden ++;
            }
        }
        if (totalHidden == totalCount)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}