using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter number " + (i + 1) + ":");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("The sum of the array elements is: " + sum);
    }
}