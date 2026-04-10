// Stores user information like name, and sleep schedulue

using System;

public class User
{
    private string name;
    private string wakeTime;
    private string sleepTime;

    public User(string name, string wakeTime, string sleepTime)
    {
        this.name = name;
        this.wakeTime = wakeTime;
        this.sleepTime = sleepTime;
    }


    public string GetWakeTime()
    {
        return wakeTime;
    }

    public string GetSleepTime()
    {
        return sleepTime;
    }
}