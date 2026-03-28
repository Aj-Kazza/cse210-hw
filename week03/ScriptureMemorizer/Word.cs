using System;

public class Word
{
    private string _text = "";
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        List<string> hiddenCharacters = new List<string>();
        _isHidden = true;
        string redact = "█";
        string text = GetDisplayText();
        foreach (char c in text)
        {
            hiddenCharacters.Add(redact);
        }

        string newText = (string.Join("", hiddenCharacters));
        _text = newText;
    }

    public void Show()
    {
        Console.WriteLine(_text);
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}