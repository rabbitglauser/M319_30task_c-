using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in something so I can reverse it:");
            string userInput  = Console.ReadLine();
            
            string reversedString = new string(userInput.Reverse().ToArray());
            Console.WriteLine("Reversed String: " + reversedString);
        }
    }
}