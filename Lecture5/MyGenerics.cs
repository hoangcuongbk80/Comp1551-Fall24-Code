using System;
using System.Collections.Generic;

class CollectionManager<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
        Console.WriteLine($"{item} added.");
    }

    public void Remove(T item)
    {
        items.Remove(item);
        Console.WriteLine($"{item} removed.");
    }

    public void ListItems()
    {
        Console.WriteLine("Items:");
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Product: {Name}, Price: ${Price}";
    }
}

class TestGenerics
{
    static void Main1(string[] args)
    {
        // Manage integers
        CollectionManager<int> intManager = new CollectionManager<int>();
        intManager.Add(10);
        intManager.Add(20);
        intManager.Remove(10);
        intManager.ListItems();

        // Manage strings
        CollectionManager<string> stringManager = new CollectionManager<string>();
        stringManager.Add("Hello");
        stringManager.Add("World");
        stringManager.Remove("Hello");
        stringManager.ListItems();

        // Manage custom objects
        CollectionManager<Product> productManager = new CollectionManager<Product>();
        productManager.Add(new Product("Laptop", 999.99));
        productManager.Add(new Product("Phone", 499.99));
        productManager.ListItems();
    }
}
