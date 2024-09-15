using System;

class Program
{
    static void Main()
    {
        string[] options = { "Rock", "Paper", "Scissors" };
        Random random = new Random();

        Console.WriteLine("Enter your choice (Rock, Paper, or Scissors):");
        string userChoice = Console.ReadLine()?.Trim();

        if (!Array.Exists(options, option => option.Equals(userChoice, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Invalid choice. Please choose Rock, Paper, or Scissors.");
            return;
        }

        string computerChoice = options[random.Next(options.Length)];
        Console.WriteLine($"Computer chose: {computerChoice}");

        DetermineWinner(userChoice, computerChoice);
    }

    static void DetermineWinner(string userChoice, string computerChoice)
    {
        if (userChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("It's a tie!");
            return;
        }

        switch (userChoice.ToLower())
        {
            case "rock":
                if (computerChoice == "Scissors")
                    Console.WriteLine("You win! Rock crushes Scissors.");
                else
                    Console.WriteLine("You lose! Paper covers Rock.");
                break;

            case "paper":
                if (computerChoice == "Rock")
                    Console.WriteLine("You win! Paper covers Rock.");
                else
                    Console.WriteLine("You lose! Scissors cut Paper.");
                break;

            case "scissors":
                if (computerChoice == "Paper")
                    Console.WriteLine("You win! Scissors cut Paper.");
                else
                    Console.WriteLine("You lose! Rock crushes Scissors.");
                break;
        }
    }
}