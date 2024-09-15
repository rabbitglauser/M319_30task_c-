using System;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to count vowels:");
            string userInput = Console.ReadLine().ToLower(); 
            
            string vowels = "aeiou";
            int vowelCount = 0;
            
            foreach (char c in userInput)
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
            }
            
            Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
        }
    }
}