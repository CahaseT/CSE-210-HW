using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string percent = Console.ReadLine();
        int grade = int.Parse(percent);
        string letter;
        if ( grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (grade >= 70)
        {
            Console.WriteLine("CONGRATS YOU PASSED");
        }
        Console.WriteLine(letter);

    }
}