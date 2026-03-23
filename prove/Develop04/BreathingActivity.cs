using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by guiding your breathing."
    ) { }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            ShowCountdown(4);
            Console.WriteLine();

            elapsed += 8;
        }

        DisplayEndingMessage();
    }
}