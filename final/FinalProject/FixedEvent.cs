using System;

public class FixedEvent
{
    private string name;
    private string date;
    private string startTime;
    private string endTime;
    public FixedEvent(string name, string date, string startTime, string endTime)
    {
        this.name = name;
        this.date = date;
        this.startTime = startTime;
        this.endTime = endTime;

    }
    public void Display()
    {
        Console.WriteLine(name + " - " + date + " " + startTime + " to " + endTime);
    }
}