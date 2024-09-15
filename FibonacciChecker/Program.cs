using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of terms for the Fibonacci sequence:");
        int numberOfTerms = Convert.ToInt32(Console.ReadLine());

        GenerateFibonacciSequence(numberOfTerms);
    }

    static void GenerateFibonacciSequence(int numberOfTerms)
    {
        int a = 0, b = 1, c;

        Console.Write("Fibonacci Sequence: ");

        for (int i = 1; i <= numberOfTerms; i++)
        {
            Console.Write(a + " ");

            c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine();
    }
}