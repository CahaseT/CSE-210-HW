using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "What are you grateful for today?"
    };

    private Random _rand = new Random();

    public GratitudeActivity() : base(
        "Listing",
        "List as many things that you are greatful for as you can."
    ) { }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        DisplayEndingMessage();
    }
}