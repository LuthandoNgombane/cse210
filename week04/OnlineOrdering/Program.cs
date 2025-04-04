// LN - This class is the main entry point of the program. It creates instances of the Address, Customer, Product, and Order classes to demonstrate their functionality.

using System;

class Program
{   
    static void Main(string[] args)
    {
        //LN - Create address objects for customers
        //LN - The address objects are created with street address, city, Initials, and country.
        Address address1 = new Address("123 Main St", "Pretoria", "PTA", "SA");
        Address address2 = new Address("456 Maple Ave", "Durban", "DBN", "SA");

        //LN - Create customer objects 
        //LN - The customer objects are created with names and addresses.
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        //LN -  Create order 1 (SA customer)
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 29.99m, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 59.99m, 1));

        //LN - Create order 2 (International customer)
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P004", 79.99m, 1));
        order2.AddProduct(new Product("Monitor", "P005", 199.99m, 1));

        //LN - Create a list of orders
        List<Order> orders = new List<Order> { order1, order2 };

        //LN - Intialize order number
        //LN - The order number is used to display the order number in the output.
        int orderNumber = 1;

        //LN - Iterate through the list of orders and display packing labels, shipping labels, and total costs
        //LN - The foreach loop iterates through each order in the list of orders.
        foreach (Order order in orders)
        {
            Console.WriteLine($"Order {orderNumber}:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
            Console.WriteLine(); 
            orderNumber++;
        }
    }
}