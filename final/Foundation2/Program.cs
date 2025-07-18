using System;

class Program
{
    static void Main(string[] args)
    {
        // customer 1 
        Product beans = new Product("beans", "B3AN5123", 3.75, 6);
        Product tortillas = new Product("tortillas", "T0RT1LL45123", 1.75, 10);
        Product cheese = new Product("cheese", "CH3353123", 4.75, 5);
        List<Product> products = new List<Product>();
        products.Add(beans);
        products.Add(tortillas);
        products.Add(cheese);
        Address address1 = new Address("4312 Bill rd", "Cincinatti", "Ohio", "USA");
        Customer customer1 = new Customer("John Taco", address1);
        Order order1 = new Order(products, customer1);

        Product dough = new Product("dough", "D0UGH321", 1.50, 8);
        Product flour = new Product("flour", "FL0UR321", 2.25, 4);
        Product milk = new Product("milk", "m1lk321", 5.25, 4);
        List<Product> products2 = new List<Product>();
        products2.Add(dough);
        products2.Add(flour);
        products2.Add(milk);
        Address address2 = new Address("9182 Bakers rd", "Buenos Aires", "Buenos Aires Province", "Argentina");
        Customer customer2 = new Customer("Philipe Baker", address2);
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Order #1");
        order1.DisplayPackingLabels();
        Console.WriteLine("Shipping Address: ");
        order1.DisplayShippingAddress();
        order1.CalculateTotalCost();
        Console.WriteLine("Total Cost: ");
        order1.DispalyTotalCost();
        Console.WriteLine();

        Console.WriteLine("Order #2");
        order2.DisplayPackingLabels();
        Console.WriteLine("Shipping Address: ");
        order2.DisplayShippingAddress();
        order2.CalculateTotalCost();
        Console.WriteLine("Total Cost: ");
        order2.DispalyTotalCost();
    }
}