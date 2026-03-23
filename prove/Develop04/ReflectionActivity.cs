using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time you showed strength."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "Would you do it again?"
    };

    private Random _rand = new Random();

    public ReflectionActivity() : base(
        "Reflection",
        "This activity helps you reflect on meaningful experiences."
    ) { }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowSpinner(5);

        int elapsed = 0;

        while (elapsed < _duration)
        {
            string question = _questions[_rand.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(5);
            elapsed += 5;
        }

        DisplayEndingMessage();
    }
}