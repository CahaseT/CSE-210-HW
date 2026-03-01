using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.Write("Enter a number (0 to quit): ");
        int number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            numbers.Add(number);

            Console.Write("Enter a number (0 to quit): ");
            number = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int average = 0;
        int largest = 0;
        foreach (int n in numbers)
        {
            sum += n;
            if (n > largest);
            {
                largest = n;
            }
        }

        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is : {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }

}