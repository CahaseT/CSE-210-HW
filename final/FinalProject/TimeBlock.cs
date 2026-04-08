// One time slot that is used to hold an assignment or event

using System;

public class TimeBlock
{
    private string day;
    private string startTime;
    private string endTime;
    private SchedulableItem scheduledItem;

    public TimeBlock(string day, string startTime, string endTime)
    {
        this.day = day;
        this.startTime = startTime;
        this.endTime = endTime;
        scheduledItem = null;
    }

    public void AssignItem(SchedulableItem item)
    {
        scheduledItem = item;
    }

    public bool IsAvailable()
    {
        return scheduledItem == null;
    }

    public string GetDay()
    {
        return day;
    }

    public string GetStartTime()
    {
        return startTime;
    }

    public string GetEndTime()
    {
        return endTime;
    }

    public SchedulableItem GetScheduledItem()
    {
        return scheduledItem;
    }

    public void Display()
    {
        if (scheduledItem == null)
        {
            Console.WriteLine(startTime + " - " + endTime + " : Open");
        }
        else
        {
            Console.WriteLine(startTime + " - " + endTime + " : " + scheduledItem.GetDetails());
        }
    }
}