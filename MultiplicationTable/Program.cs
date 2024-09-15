using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for user input
            Console.WriteLine("Give me a number for the multiplication table:");
            
            // Parse user input into an integer
            int UserInput = int.Parse(Console.ReadLine());

            // Print multiplication table for the given number (from 1 to 10)
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{UserInput} x {i} = {UserInput * i}");
            }
        }
    }
}