using System;
using System.Collections.Generic;

class BankAccount
{
    private decimal balance;
    private List<string> transactionHistory;

    public BankAccount()
    {
        balance = 0.0m;
        transactionHistory = new List<string>();
    }

    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }
        balance += amount;
        transactionHistory.Add($"Deposited: ${amount}");
        Console.WriteLine($"Successfully deposited: ${amount}");
    }

    public void Withdraw(decimal amount)
    {
        if(amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be positive.");
            return;
        }
        if(amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }
        balance -= amount;
        transactionHistory.Add($"Withdrew: ${amount}");
        Console.WriteLine($"Successfully withdrew: ${amount}");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current balance: ${balance}");
    }

    public void ViewTransactionHistory()
    {
        Console.WriteLine("Transaction History:");
        foreach (var transaction in transactionHistory)
        {
            Console.WriteLine(transaction);
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. View Transaction History");
            Console.WriteLine("5. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        account.Deposit(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;
                case 2:
                    Console.Write("Enter withdrawal amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                    {
                        account.Withdraw(withdrawAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;
                case 3:
                    account.CheckBalance();
                    break;
                case 4:
                    account.ViewTransactionHistory();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}