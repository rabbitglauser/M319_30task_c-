using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();

        if (IsValidPassword(password))
        {
            Console.WriteLine("Password is valid.");
        }
        else
        {
            Console.WriteLine("Password does not meet the criteria.");
        }
    }

    static bool IsValidPassword(string password)
    {
        if (password.Length < 8)
        {
            return false;
        }

        bool hasUpperCase = false;
        bool hasLowerCase = false;
        bool hasDigit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c)) hasUpperCase = true;
            if (char.IsLower(c)) hasLowerCase = true;
            if (char.IsDigit(c)) hasDigit = true;
        }

        return hasUpperCase && hasLowerCase && hasDigit;
    }
}