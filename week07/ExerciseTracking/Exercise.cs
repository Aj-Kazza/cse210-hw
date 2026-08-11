using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    private string _name;

    public Activity(DateTime date, int minutes, string name)
    {
        _date = date;
        _minutes = minutes;
        _name = name;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetMinutes()
    {
        return _minutes;
    }
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} {GetName()} ({GetMinutes()} min): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}