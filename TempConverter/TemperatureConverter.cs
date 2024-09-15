/*Temperature Converter


Task: Write a program that converts temperatures from Celsius to Fahrenheit and vice versa. Allow the user to choose the conversion direction.*/ 
using System;

namespace TempConverter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the temperature to convert: ");
            double temperature = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the unit to convert from (Celsius or Fahrenheit): ");
            string fromUnit = Console.ReadLine();
            
            Console.WriteLine("Enter the unit to convert to (Celsius or Fahrenheit): ");
            string toUnit = Console.ReadLine();
            
            try
            {
                double convertedTemperature = ConvertTemperature(temperature, fromUnit, toUnit);
                Console.WriteLine($"The converted temperature is: {convertedTemperature} {toUnit}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        static double ConvertTemperature(double temperature, string fromUnit, string toUnit)
        {
            if (fromUnit == "Celsius" && toUnit == "Fahrenheit")
            {
                return (temperature * 9 / 5) + 32;
            }
            else if (fromUnit == "Fahrenheit" && toUnit == "Celsius")
            {
                return (temperature - 32) * 5 / 9;
            }
            else
            {
                throw new ArgumentException("Invalid conversion units");
            }
        }
    }
}