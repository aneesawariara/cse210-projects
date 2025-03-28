using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        Address address1 = new Address("Thige Road", "Nairobi City", "Nairobi", "Kenya");
        Address address2 = new Address("123 Main St", "New York", "NY", "USA");

        Customer customer1 = new Customer("Mildred Maina", address1);
        Customer customer2 = new Customer("James Okoth", address2);

        Product product1 = new Product("Keychain", "TS34", 3.99, 3);
        Product product2 = new Product("Loc Charm", "BA123", 0.99, 13);
        Product product3 = new Product("Phone Case", "PA456", 15.99, 2);
        Product product4 = new Product("Earphones", "PA267", 10.23, 1);
        Product product5 = new Product("Waistbeads", "BA436", 20.45, 4);
        Product product6 = new Product("Stickers", "A675", 0.69, 15);

        List<Product> order1Product = new List<Product> {product1, product5, product4};
        List<Product> order2Product = new List<Product> {product2, product3, product6};

        Order order1 = new Order(customer1, order1Product);
        Order order2 = new Order(customer2, order2Product);

        Console.WriteLine("Order 1 : ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.CalculateTotalPrice()}");

        Console.WriteLine();
        Console.WriteLine("Order 2 : ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.CalculateTotalPrice()}");

        
    }
}