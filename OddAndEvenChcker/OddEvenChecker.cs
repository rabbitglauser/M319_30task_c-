/*Odd or Even Checker


Task: Write a program that takes an integer from the user and determines whether it is odd or even.*/
using System;
                      
namespace OddsAndEvens
{
    public class OddAndEvenChecker
    {
        public int UserInput { get; set; }

        public void GetUserInput()
        {
            Console.WriteLine("Give me a number you want to check if it is even or odd:");
            UserInput = int.Parse(Console.ReadLine());
        }

        public void OddAndEvenCalculator()
        {
            if (UserInput % 2 == 0)
            {
                Console.WriteLine("You entered an even number.");
            }
            else
            {
                Console.WriteLine("You entered an odd number.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            OddAndEvenChecker oddAndEvenChecker = new OddAndEvenChecker();
            oddAndEvenChecker.GetUserInput();
            oddAndEvenChecker.OddAndEvenCalculator();
        }
    }
}
