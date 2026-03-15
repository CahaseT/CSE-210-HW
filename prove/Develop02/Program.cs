using System;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    public void ShowMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Motivation");
        Console.WriteLine("2. Write");
        Console.WriteLine("3. Display");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Save");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    public void Run()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            ShowMenu();
            string input = Console.ReadLine();
            choice = int.Parse(input);
            Console.WriteLine();

            if (choice ==1)
            {
                string motivation = promptGenerator.GetRandomMotivation();
                Console.WriteLine($"Motivation: {motivation}");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(date, prompt, response);
                journal.AddEntry(newEntry);

                Console.WriteLine("Entry added.");
                Console.WriteLine();
            }
            else if (choice == 3)
            {
                journal.DisplayEntries();
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                if (System.IO.File.Exists(fileName))
                {
                    journal.LoadEntries(fileName);
                    Console.WriteLine("Journal loaded successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }

                Console.WriteLine();
            }
            else if (choice == 5)
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();

                journal.SaveEntries(fileName);
                Console.WriteLine("Journal saved successfully.");
                Console.WriteLine();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine();
            }
        }
    }
}