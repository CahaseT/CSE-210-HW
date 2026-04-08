// Creates Weekly Schedule and places item into the available time blocks remain

using System;

public class Scheduler
{
    private User user;
    private WeekSchedule weekSchedule;

    public Scheduler(User user)
    {
        this.user = user;
        weekSchedule = new WeekSchedule();
    }

    public void GenerateSchedule()
    {
        string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        foreach (string dayName in weekdays)
        {
            DaySchedule day = new DaySchedule(dayName);

            DateTime start = DateTime.Parse(user.GetWakeTime());
            DateTime end = DateTime.Parse(user.GetSleepTime());

            while (start < end)
            {
                DateTime next = start.AddHours(1);

                if (next <= end)
                {
                    day.AddTimeBlock(new TimeBlock(
                        dayName,
                        start.ToString("h:mm tt"),
                        next.ToString("h:mm tt")
                    ));
                }

                start = next;
            }

            weekSchedule.AddDay(day);
        }
    }

    public void ScheduleAssignment(SchedulableItem item)
    {
        DaySchedule day = weekSchedule.GetDay(item.GetDay());

        if (day == null)
        {
            return;
        }

        if (item is FixedEvent)
        {
            FixedEvent fixedEvent = (FixedEvent)item;

            foreach (TimeBlock block in day.GetTimeBlocks())
            {
                if (block.IsAvailable() &&
                    block.GetStartTime().ToLower() == fixedEvent.GetStartTime().ToLower() &&
                    block.GetEndTime().ToLower() == fixedEvent.GetEndTime().ToLower())
                {
                    block.AssignItem(fixedEvent);
                    return;
                }
            }
        }
        else if (item is Assignment)
        {
            int blocksNeeded = (int)Math.Ceiling(item.GetDurationHours());
            int blocksAssigned = 0;

            foreach (TimeBlock block in day.GetTimeBlocks())
            {
                if (block.IsAvailable())
                {
                    block.AssignItem(item);
                    blocksAssigned++;

                    if (blocksAssigned == blocksNeeded)
                    {
                        return;
                    }
                }
            }
        }
    }

    public WeekSchedule GetWeekSchedule()
    {
        return weekSchedule;
    }
}