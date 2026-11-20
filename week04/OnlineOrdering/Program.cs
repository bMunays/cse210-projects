using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Order 1: Domestic Customer (USA - $5 shipping)
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Jordan Vance", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mechanical Keyboard", "KB-101", 75.00, 1));
        order1.AddProduct(new Product("USB-C Docking Station", "DC-204", 45.50, 2));

        // Order 2: International Customer (Outside USA - $35 shipping)
        Address address2 = new Address("14 Herbert Chitepo Street", "Mutare", "Manicaland", "Zimbabwe");
        Customer customer2 = new Customer("Tendai Moyo", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("24V MPPT Charge Controller", "SL-309", 120.00, 1));
        order2.AddProduct(new Product("MC4 Solar Connector Pair", "SL-112", 8.25, 4));
        order2.AddProduct(new Product("10AWG Solar Extension Cable", "SL-415", 22.00, 2));

        // Display Order 1 Details
        Console.WriteLine("=========================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("=========================================\n");

        // Display Order 2 Details
        Console.WriteLine("=========================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("=========================================");
    }
}