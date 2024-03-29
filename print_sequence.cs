using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        if (int.TryParse(Console.ReadLine(), out int number)) // Read user input and parse it as an integer
        {
            Console.WriteLine($"Printing a loop for {number}:");
            for (int i = 1; i <= number; i++) // Loop from 1 to the given number
            {
                Console.WriteLine($"Iteration {i}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

