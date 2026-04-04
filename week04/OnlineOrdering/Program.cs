using System;

class Program
{
    static void Main(string[] args)
    {
       

        Product p1 = new Product("shampoo", "shmp1", 5, 1);
        Product p2 = new Product("candy", "cndy44", 0.50, 2);
        Product p3 = new Product("mint gum", "bbgm2", 0.50, 2);
        Product p4 = new Product("sweet popcorn", "ppcn2", 5, 1);

        Address a1 = new Address("21 jump street", "brooklyn", "new york", "USA");
        Customer c1 = new Customer("Mr Liberty", a1);

        Order o1 = new Order(c1,a1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);
        o1.AddProduct(p4);
        
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine($"Total: ${o1.CalculateTotal()}");
    }
}