// Holds all of the days of the week as well as displays the entire schedule

using System;
using System.Collections.Generic;

public class WeekSchedule
{
    private List<DaySchedule> days;

    public WeekSchedule()
    {
        days = new List<DaySchedule>();
    }

    public void AddDay(DaySchedule day)
    {
        days.Add(day);
    }

    public DaySchedule GetDay(string dayName)
    {
        foreach (DaySchedule day in days)
        {
            if (day.GetDayName().ToLower() == dayName.ToLower())
            {
                return day;
            }
        }

        return null;
    }

    public List<DaySchedule> GetDays()
    {
        return days;
    }

    public void DisplayWeekSchedule()
    {
        foreach (DaySchedule day in days)
        {
            day.DisplaySchedule();
        }
    }
}