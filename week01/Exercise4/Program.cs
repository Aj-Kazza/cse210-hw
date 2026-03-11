using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int userNumber = -1;
        int count = 0;

        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            userNumber = int.Parse(answer);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                sum += userNumber;
                count += 1;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / count;
        Console.WriteLine($"The average is: {average}");


        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}