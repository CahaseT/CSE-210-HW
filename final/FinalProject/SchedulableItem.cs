// The Base class that is used for Assignment and Fixed events.

using System;

public abstract class SchedulableItem
{
    protected string title;
    protected string day;
    protected double durationHours;

    public SchedulableItem(string title, string day, double durationHours)
    {
        this.title = title;
        this.day = day;
        this.durationHours = durationHours;
    }

    public string GetDay()
    {
        return day;
    }

    public double GetDurationHours()
    {
        return durationHours;
    }

    public abstract string GetDetails();
}