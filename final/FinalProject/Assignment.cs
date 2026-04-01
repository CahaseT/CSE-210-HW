using System;

public class Assignment
{
    private string name;
    private string dueDate;

    public Assignment(string name, string dueDate)
    {
        this.name = name;
        this.dueDate = dueDate;
    }
    public void Display()
    {
        Console.WriteLine(name + " - Due: " + dueDate);
    }
}