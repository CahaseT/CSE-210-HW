using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {new BreathingActivity().Run();}
            else if (choice == "2")
            {new ReflectionActivity().Run();}
            else if (choice == "3")
            {new ListingActivity().Run();}
            else if (choice == "4")
            {new GratitudeActivity().Run();}
            // stretch assignment is GratitudeActivity
        }
    }
}