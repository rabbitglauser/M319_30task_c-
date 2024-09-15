/*Simple Calculator


Task: Create a simple calculator that can perform basic arithmetic operations (addition, subtraction, multiplication, and division). Ask the user for two numbers and the operation they want to perform, then print the result.*/
using System;

namespace SimpleCalculator
{
    class Calculator
    {
        public int UserInput1 { get; set; }
        public int UserInput2 { get; set; }
        public char Operator { get; set; }
        
        public void GetUserInput()
        {
            Console.WriteLine("Please enter your first number: ");
            UserInput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            UserInput2 = int.Parse(Console.ReadLine());
        }

        public void ChooseOperator()
        {
            Console.WriteLine("Please enter your operator (+, -, /, *): ");
            Operator = char.Parse(Console.ReadLine());
        }

        public void PerformCalculation()
        {
            switch (Operator)
            {
                case '+':
                    Console.WriteLine($"The result is: {UserInput1 + UserInput2}");
                    break;
                case '-':
                    Console.WriteLine($"The result is: {UserInput1 - UserInput2}");
                    break;
                case '*':
                    Console.WriteLine($"The result is: {UserInput1 * UserInput2}");
                    break;
                case '/':
                    if (UserInput2 != 0)
                    {
                        Console.WriteLine($"The result is: {UserInput1 / UserInput2}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator entered.");
                    break;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            calculator.GetUserInput();
            calculator.ChooseOperator();
            calculator.PerformCalculation();
        }
    }
}