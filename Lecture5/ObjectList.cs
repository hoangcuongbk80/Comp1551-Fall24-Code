using System;
using System.Collections.Generic;
using System.Linq;

class MyProduct
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public MyProduct(string name, string category, double price, int quantity)
    {
        Name = name;
        Category = category;
        Price = price;
        Quantity = quantity;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Category: {Category}, Price: {Price}, Quantity: {Quantity}");
    }
}

class TestList
{
    static void Main1(string[] args)
    {
        List<MyProduct> products = new List<MyProduct> {
            new MyProduct("Laptop", "Electronics", 999.99, 5),
            new MyProduct("Chair", "Furniture", 49.99, 10),
            new MyProduct("Headphones", "Electronics", 29.99, 15),
            new MyProduct("Desk", "Furniture", 89.99, 8),
            new MyProduct("Mouse", "Electronics", 19.99, 20)
        };

        // Sort products by price in ascending order
        Console.WriteLine("Products sorted by price:");
        var sortedByPrice = products.OrderBy(p => p.Price);
        foreach (var product in sortedByPrice)
        {
            product.DisplayInfo();
        }

        Console.WriteLine();

        // Find product with the highest quantity
        var highestQuantityProduct = products.OrderByDescending(p => p.Quantity).First();
        Console.WriteLine("Product with the highest quantity:");
        highestQuantityProduct.DisplayInfo();

        Console.WriteLine();

        // Remove all products in a specific category (e.g., "Furniture")
        string categoryToRemove = "Furniture";
        products.RemoveAll(p => p.Category == categoryToRemove);

        Console.WriteLine($"Products after removing all in category '{categoryToRemove}':");
        foreach (var product in products)
        {
            product.DisplayInfo();
        }
    }
}
