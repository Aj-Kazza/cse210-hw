using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = [];

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public string GetDisplayText()
    {
        string commentsString = "";
        foreach (Comment comment in _comments)
        {
            commentsString = commentsString + $"{comment.GetDisplayText()}\r\n";
        }

        return '"' + $"{_title}" + '"' + $" by {_author} " + "[" + _length + "s]\r\n" + commentsString;
    }
}