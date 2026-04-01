using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
class Program
{
    static void Main(string[] args)
    {
        List<Assignment> assignments = new List<Assignment>();
        List<FixedEvent> fixedEvents = new List<FixedEvent>();
        string choice = "0";
        string subChoice = "0";
        Console.WriteLine("Welcome to Chase's Schedule Planner!");

        while (choice != "3")
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - Add Info");
            Console.WriteLine("2 - See Schedule");
            Console.WriteLine("3 - Exit");

            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("1 - Add Assignment");
                Console.WriteLine("2 - Add Event");
                subChoice = Console.ReadLine();
                if (subChoice == "1")
                {
                    Console.WriteLine("Enter Assignment name");
                    string assignmentName = Console.ReadLine();
                    Console.WriteLine("Enter due date");
                    string dueDate = Console.ReadLine();
                    Assignment a = new Assignment(assignmentName, dueDate);
                    a.Display();
                    assignments.Add(a);
                }
                else if (subChoice == "2")
                {
                    Console.WriteLine("Enter Event name");
                    string eventName = Console.ReadLine();

                    Console.WriteLine("Enter event date");
                    string date = Console.ReadLine();

                    Console.WriteLine("Enter start time");
                    string startTime = Console.ReadLine();

                    Console.WriteLine("Enter end time");
                    string endTime = Console.ReadLine();

                    FixedEvent e = new FixedEvent(eventName, date, startTime, endTime);
                    e.Display();
                    fixedEvents.Add(e);
                }

           
            }
            else if (choice == "2")
            {
                Console.WriteLine("Schedule:");
                Console.WriteLine("");
                Console.WriteLine("Assignments:");
                foreach (Assignment assignment in assignments)
                {
                    assignment.Display();
                }
                Console.WriteLine("");
                Console.WriteLine("Events:");
                foreach(FixedEvent fixedEvent in fixedEvents)
                {
                    fixedEvent.Display();
                }
            }
        }
    }  
}
        

