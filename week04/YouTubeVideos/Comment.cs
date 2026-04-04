using System;

public class Comment
{
    private string _username;
    private string _comment;

    public Comment(string username, string comment)
    {
        _username = username;
        _comment = comment;
    }
    public string GetDisplayText()
    {
        return $"   {_username}: " + '"' + _comment +'"';
    }
}