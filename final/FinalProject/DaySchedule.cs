// Stores time blocks for a single day, as well as does displays for them.

using System;
using System.Collections.Generic;

public class DaySchedule
{
    private string dayName;
    private List<TimeBlock> timeBlocks;

    public DaySchedule(string dayName)
    {
        this.dayName = dayName;
        timeBlocks = new List<TimeBlock>();
    }

    public void AddTimeBlock(TimeBlock block)
    {
        timeBlocks.Add(block);
    }

    public List<TimeBlock> GetTimeBlocks()
    {
        return timeBlocks;
    }

    public string GetDayName()
    {
        return dayName;
    }

    public void DisplaySchedule()
    {
        Console.WriteLine();
        Console.WriteLine("|-|-| " + dayName + " |-|-|");

        foreach (TimeBlock block in timeBlocks)
        {
            block.Display();
        }
    }
}