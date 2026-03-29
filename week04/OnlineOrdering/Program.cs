using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product p1 = new Product("Laptop", "101", 1000, 1);
        Product p2 = new Product("Mouse", "102", 25, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);

        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine();


        // ORDER 2 (NON-USA)
        Address address2 = new Address("45 Cairo Road", "Lusaka", "Lusaka", "Zambia");
        Customer customer2 = new Customer("Mary Phiri", address2);

        Product p3 = new Product("Phone", "201", 500, 1);
        Product p4 = new Product("Headphones", "202", 50, 2);

        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);

        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}