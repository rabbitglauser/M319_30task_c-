using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - ${Price}";
    }
}

class ShoppingCart
{
    private List<Product> cart;
    
    public ShoppingCart()
    {
        cart = new List<Product>();
    }

    public void AddProduct(string name, decimal price)
    {
        cart.Add(new Product(name, price));
        Console.WriteLine($"Product \"{name}\" with price ${price} added to the cart.");
    }

    public void RemoveProduct(int index)
    {
        if (index >= 0 && index < cart.Count)
        {
            string name = cart[index].Name;
            cart.RemoveAt(index);
            Console.WriteLine($"Product \"{name}\" removed from the cart.");
        }
        else
        {
            Console.WriteLine("Invalid product index.");
        }
    }

    public void ViewTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in cart)
        {
            totalCost += product.Price;
        }
        Console.WriteLine($"Total cost: ${totalCost}");
    }

    public void DisplayCart()
    {
        if (cart.Count == 0)
        {
            Console.WriteLine("The cart is empty.");
        }
        else
        {
            Console.WriteLine("Products in the cart:");
            for (int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cart[i]}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart shoppingCart = new ShoppingCart();
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Product to Cart");
            Console.WriteLine("2. Remove Product from Cart");
            Console.WriteLine("3. View Total Cost");
            Console.WriteLine("4. Display Cart");
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
                    Console.Write("Enter product name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter product price: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal price))
                    {
                        shoppingCart.AddProduct(name, price);
                    }
                    else
                    {
                        Console.WriteLine("Invalid price.");
                    }
                    break;
                case 2:
                    Console.Write("Enter product index to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int removeIndex))
                    {
                        shoppingCart.RemoveProduct(removeIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;
                case 3:
                    shoppingCart.ViewTotalCost();
                    break;
                case 4:
                    shoppingCart.DisplayCart();
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