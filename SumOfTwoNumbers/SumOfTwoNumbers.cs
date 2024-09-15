/*Sum of Two Numbers


Task: Create a program that asks the user for two numbers, adds them together, and prints the result.*/
using System;
namespace OddsAndEvens
{
    public class Calculator
    {
        public int UserInput1 { get; set; }
        public int UserInput2 { get; set; }

        public void GetUserInput()
        {
            Console.WriteLine("Enter the first number: ");
            UserInput1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            UserInput2 = int.Parse(Console.ReadLine());
        }

        public int CalculateSum()
        {
            return UserInput1 + UserInput2;
        }
    }

    class Program
    {
        static void Main()
        {

            Calculator calculator = new Calculator();
            
            calculator.GetUserInput();

            Console.WriteLine($"The sum of the two entered numbers is {calculator.CalculateSum()}");
        }
    }
}