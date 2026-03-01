using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int squared = SquareNumber(favNumber);
        DisplayResult(name, squared, birthYear);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number ");
        return int.Parse(Console.ReadLine());
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Enter the year you were born ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int squaredNumber, int birthyear)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthyear;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    
}
