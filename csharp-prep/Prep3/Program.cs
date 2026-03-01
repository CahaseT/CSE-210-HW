using System;
using System.Net;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int MagicNumber = int.Parse(Console.ReadLine());
        int response = 1;
        while (response != MagicNumber)
        {  
        
            Console.Write("What is your guess 1-100? ");
            response = int.Parse(Console.ReadLine());
            if (response > MagicNumber)
        {
            Console.WriteLine("TOO HIGH!");
        }
            else if (response < MagicNumber)
        {
            Console.WriteLine("TOO LOW!");
        }
        }
        Console.WriteLine("GOOD JOB!");
    }
}