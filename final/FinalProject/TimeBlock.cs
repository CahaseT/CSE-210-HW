using System;
public class TimeBlock
{
    private string date;
    private string startTime;
    private string endTime;
    private bool isOccupied;
    public TimeBlock(string date, string startTime, string endTime)
    {
        this.date = date;
        this.startTime = startTime;
        this.endTime = endTime;
        isOccupied = false;
    }
}