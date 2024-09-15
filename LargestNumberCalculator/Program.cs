using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int largestNumber = number1;

        if (number2 > largestNumber)
        {
            largestNumber = number2;
        }

        if (number3 > largestNumber)
        {
            largestNumber = number3;
        }

        Console.WriteLine("The largest number is: " + largestNumber);
    }
}