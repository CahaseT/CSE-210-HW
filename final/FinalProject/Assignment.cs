// represents the task that will be moved around

using System;

public class Assignment : SchedulableItem
{
    private string dueDate;
    private int priority;

    public Assignment(string title, string day, double durationHours, string dueDate, int priority)
        : base(title, day, durationHours)
    {
        this.dueDate = dueDate;
        this.priority = priority;
    }

    public string GetDueDate()
    {
        return dueDate;
    }

    public int GetPriority()
    {
        return priority;
    }

    public override string GetDetails()
    {
        return title + " - " + day + " - " + durationHours + " hours - Due: " + dueDate + " - Priority: " + priority;
    }
}