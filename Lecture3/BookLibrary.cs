using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;
    public int Year;

    // Constructor for Book class
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    // Method to display book details
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}");
    }
}

class Library
{
    private List<Book> books; // Attribute: List of books

    // Constructor to initialize the list of books
    public Library()
    {
        books = new List<Book>();
    }

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' by {book.Author} added to the library.");
    }

    // Method to list all books in the library
    public void ListBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available in the library.");
        }
        else
        {
            Console.WriteLine("Books available in the library:");
            foreach (Book book in books)
            {
                book.DisplayInfo();
            }
        }
    }
}

// Main method to demonstrate classes and objects
class TestBookLibrary
{
    static void Main1(string[] args)
    {
        Library myLibrary = new Library();

        // Creating book objects
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);

        // Adding books to the library
        myLibrary.AddBook(book1);
        myLibrary.AddBook(book2);

        // Listing all books in the library
        myLibrary.ListBooks();
    }
}
