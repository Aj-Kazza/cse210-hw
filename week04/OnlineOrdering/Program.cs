using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

               

        Product p1 = new Product("shampoo", "shmp1", 5, 1);
        Product p2 = new Product("candy", "cndy44", 0.50, 2);
        Product p3 = new Product("mint gum", "bbgm2", 0.50, 2);
        Product p4 = new Product("sweet popcorn", "ppcn2", 5, 1);
        Product p5 = new Product("toothpaste", "colgv1", 2.50, 5);
        Product p6 = new Product("potato chips", "pingles1", 3.70, 2);
        Product p7 = new Product("water", "500mlfw", 2.00, 5);

        Address a1 = new Address("21 jump street", "brooklyn", "new york", "USA");
        Customer c1 = new Customer("Mr Liberty", a1);

        Address a2 = new Address("67 Street Street", "Tung Sahur", "Victoria", "Australia");
        Customer c2 = new Customer("Frapucinno Bannanino", a2);

        Order o1 = new Order(c1,a1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o1.AddProduct(p4);

        Order o2 = new Order(c2, a2);
        o2.AddProduct(p5);
        o2.AddProduct(p6);
        o2.AddProduct(p7);

        printOrder(o1);
        printOrder(o2);
        
        
        
    }

    static void printOrder(Order order)
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"Total: ${order.CalculateTotal()}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("");
        }

}