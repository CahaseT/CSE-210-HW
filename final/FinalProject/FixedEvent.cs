// Represents those events that cannot be moved around.

using System;

public class FixedEvent : SchedulableItem
{
    private string startTime;
    private string endTime;

    public FixedEvent(string title, string day, double durationHours, string startTime, string endTime)
        : base(title, day, durationHours)
    {
        this.startTime = startTime;
        this.endTime = endTime;
    }

    public string GetStartTime()
    {
        return startTime;
    }

    public string GetEndTime()
    {
        return endTime;
    }

    public override string GetDetails()
    {
        return title + " - " + day + " - " + startTime + " to " + endTime;
    }
}