// Runs program (believe it or not) handls output and controls the program's flow overall

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Chase's Schedule Planner!");
        Console.WriteLine();

        Console.Write("Please Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your time to wake up (example: 8:00 AM): ");
        string wakeTime = Console.ReadLine();

        Console.Write("Enter time to sleep : ");
        string sleepTime = Console.ReadLine();

        User user = new User(name, wakeTime, sleepTime);
        Scheduler scheduler = new Scheduler(user);

        scheduler.GenerateSchedule();

        List<Assignment> assignments = new List<Assignment>();
        List<FixedEvent> fixedEvents = new List<FixedEvent>();

        string choice = "0";

        while (choice != "4")
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1: Add Assignment");
            Console.WriteLine("2: Add Event");
            Console.WriteLine("3: See Your Full Schedule");
            Console.WriteLine("4: Exit");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter assignment title: ");
                string title = Console.ReadLine();

                Console.Write("Enter day: ");
                string day = Console.ReadLine();

                Console.Write("Enter duration in hours: ");
                double durationHours = double.Parse(Console.ReadLine());

                Console.Write("Enter due date: ");
                string dueDate = Console.ReadLine();

                Console.Write("Enter priority: ");
                int priority = int.Parse(Console.ReadLine());

                Assignment assignment = new Assignment(title, day, durationHours, dueDate, priority);
                assignments.Add(assignment);

                scheduler.ScheduleAssignment(assignment);

                Console.WriteLine("Assignment added.");
            }
            else if (choice == "2")
            {
                Console.Write("Enter event title: ");
                string title = Console.ReadLine();

                Console.Write("Enter day: ");
                string day = Console.ReadLine();

                Console.Write("Enter start time: ");
                string startTime = Console.ReadLine();

                Console.Write("Enter end time: ");
                string endTime = Console.ReadLine();

                double durationHours = 1;

                FixedEvent fixedEvent = new FixedEvent(title, day, durationHours, startTime, endTime);
                fixedEvents.Add(fixedEvent);

                scheduler.ScheduleAssignment(fixedEvent);

                Console.WriteLine("Event added.");
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                Console.WriteLine("|-|-| YOUR WEEK |-|-|");
                scheduler.GetWeekSchedule().DisplayWeekSchedule();

                Console.WriteLine();
                Console.WriteLine("|-|-| YOUR ASSIGNMENTS |-|-|");
                foreach (Assignment assignment in assignments)
                {
                    Console.WriteLine(assignment.GetDetails());
                }

                Console.WriteLine();
                Console.WriteLine("|-|-| YOUR EVENTS |-|-|");
                foreach (FixedEvent fixedEvent in fixedEvents)
                {
                    Console.WriteLine(fixedEvent.GetDetails());
                }
            }
        }
    }
}