using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        Address address = new Address("123 Main Street", "Springfield", "IL", "US");
        Customer customer1 = new Customer("Joseph Garlick", address);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 1, 999.99f, 1));
        order1.AddProduct(new Product("Mouse", 2, 29.99f, 2));

        Console.WriteLine($"Packing Label: {order1.GetPackingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Shipping Label: {order1.GetShippingLabel()}");


    }
}