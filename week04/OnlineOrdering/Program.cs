using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (Japan Customer - $35 international shipping)
        Address address1 = new Address("45 Sakura Dori", "Narita", "Chiba", "Japan");
        Customer customer1 = new Customer("Kenji Sato", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Wireless Mouse", "WM101", 25.00, 2);
        Product product2 = new Product("USB-C Cable", "UC202", 10.00, 3);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("=================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        // Order 2 (USA Customer - $5 domestic shipping)
        Address address2 = new Address("123 Maple Street", "Rexburg", "ID", "USA");
        Customer customer2 = new Customer("Sarah Johnson", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Mechanical Keyboard", "MK303", 80.00, 1);
        Product product4 = new Product("Laptop Stand", "LS404", 30.00, 1);
        Product product5 = new Product("Desk Mat", "DM505", 15.00, 2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("=================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}
