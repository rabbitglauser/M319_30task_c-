using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a non-negative integer to calculate its factorial:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Invalid input. Factorial is not defined for negative numbers.");
            return;
        }

        long factorial = CalculateFactorial(number);
        Console.WriteLine($"The factorial of {number} is {factorial}.");
    }

    static long CalculateFactorial(int number)
    {
        if (number == 0 || number == 1)
        {
            return 1;
        }

        long result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}