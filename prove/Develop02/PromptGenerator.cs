using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "Who did I miss the most today?",
        "What is one part of my day I wish I could do over?",
        "One tender mercy from today?",
        "What did I eat for breakfast, and why?",
        "Who were the first and last people I talked to today?"
    };

    private List<string> _motivations = new List<string>()
    {
        "Small progress is still progress.",
        "Consistency turns small daily actions into big lifelong results.",
        "You don't need to be perfect, you just need to show up.",
        "A little progress every day, beats a burst of effort once a week.",
        "It's never too late to try."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomMotivation()
    {
        Random random = new Random();
        int index = random.Next(_motivations.Count);
        return _motivations[index];
    }
}