using System;
using System.Collections.Generic;

enum MenuOptions
{
    AddBook = 1,
    RemoveBook,
    ListBooks,
    Exit
}

class Book
{
    public string Title { get; set; }

    public Book(string title)
    {
        Title = title;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
    }
}

class TestEnum
{
    static List<Book> books = new List<Book>();

    static void Main1(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            int choice = int.Parse(Console.ReadLine());

            MenuOptions selectedOption = (MenuOptions)choice;

            switch (selectedOption)
            {
                case MenuOptions.AddBook:
                    AddBook();
                    break;
                case MenuOptions.RemoveBook:
                    RemoveBook();
                    break;
                case MenuOptions.ListBooks:
                    ListBooks();
                    break;
                case MenuOptions.Exit:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nSelect an option:");
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. Remove Book");
        Console.WriteLine("3. List Books");
        Console.WriteLine("4. Exit");
    }

    static void AddBook()
    {
        Console.Write("Enter the title of the book: ");
        string title = Console.ReadLine();
        books.Add(new Book(title));
        Console.WriteLine("Book added successfully!");
    }

    static void RemoveBook()
    {
        Console.Write("Enter the title of the book to remove: ");
        string title = Console.ReadLine();
        books.RemoveAll(b => b.Title == title);
        Console.WriteLine("Book removed (if it existed)!");
    }

    static void ListBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
        }
        else
        {
            Console.WriteLine("Books in the library:");
            foreach (Book book in books)
            {
                book.Display();
            }
        }
    }
}
