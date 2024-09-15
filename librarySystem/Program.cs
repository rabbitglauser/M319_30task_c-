using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public int TotalCopies { get; set; }
    public int AvailableCopies { get; set; }

    public Book(string title, int totalCopies)
    {
        Title = title;
        TotalCopies = totalCopies;
        AvailableCopies = totalCopies;
    }
}

class Library
{
    private Dictionary<string, Book> books;

    public Library()
    {
        books = new Dictionary<string, Book>();
    }

    public void AddBook(string title, int totalCopies)
    {
        if (books.ContainsKey(title))
        {
            books[title].TotalCopies += totalCopies;
            books[title].AvailableCopies += totalCopies;
        }
        else
        {
            books[title] = new Book(title, totalCopies);
        }
        Console.WriteLine($"Added {totalCopies} copies of \"{title}\" to the library.");
    }

    public void BorrowBook(string title)
    {
        if (books.ContainsKey(title))
        {
            if (books[title].AvailableCopies > 0)
            {
                books[title].AvailableCopies--;
                Console.WriteLine($"You have borrowed \"{title}\".");
            }
            else
            {
                Console.WriteLine($"Sorry, \"{title}\" is not available.");
            }
        }
        else
        {
            Console.WriteLine($"Sorry, \"{title}\" is not in the library.");
        }
    }

    public void ReturnBook(string title)
    {
        if (books.ContainsKey(title))
        {
            books[title].AvailableCopies++;
            Console.WriteLine($"You have returned \"{title}\".");
        }
        else
        {
            Console.WriteLine($"Sorry, \"{title}\" is not in the library.");
        }
    }

    public void ListBooks()
    {
        Console.WriteLine("Books in the library:");
        foreach (var book in books.Values)
        {
            Console.WriteLine($"Title: \"{book.Title}\", Total Copies: {book.TotalCopies}, Available Copies: {book.AvailableCopies}");
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Return Book");
            Console.WriteLine("4. List Books");
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
                    Console.Write("Enter book title: ");
                    string addTitle = Console.ReadLine();
                    Console.Write("Enter number of copies: ");
                    if (int.TryParse(Console.ReadLine(), out int addCopies))
                    {
                        library.AddBook(addTitle, addCopies);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of copies.");
                    }
                    break;
                case 2:
                    Console.Write("Enter book title: ");
                    string borrowTitle = Console.ReadLine();
                    library.BorrowBook(borrowTitle);
                    break;
                case 3:
                    Console.Write("Enter book title: ");
                    string returnTitle = Console.ReadLine();
                    library.ReturnBook(returnTitle);
                    break;
                case 4:
                    library.ListBooks();
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