using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers;
        numbers = new List<int>();

        int numberInput = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (numberInput != 0)
        {
            Console.Write("Enter a number: ");
            numberInput = int.Parse(Console.ReadLine());
            if (numberInput != 0)
            {
                numbers.Add(numberInput);
            }
        }

        int total = 0;
        int count = 0;
        foreach (int number in numbers)
        {
            total = total + number;
            count = count +1;
        }
        Console.WriteLine($"Sum is: {total}");
        //Console.WriteLine($"Count is: {count}");
        int average = total / count;
        Console.WriteLine($"Average is: {average}");

        int maximum = numbers.Max();

        Console.WriteLine($"Largest is: {maximum}");

    }
}