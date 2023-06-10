using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string originalNumber = Console.ReadLine();
            number = int.Parse(originalNumber);

            if (number !=0)
            {
                numbers.Add(number);
            }
        }
        int total = 0;
        int largest = 0;

        foreach (int item in numbers)
        {
            total = total + item;

            if (item > largest)
            {
                largest = item;
            }
        }

        float average = ((float)total) /(numbers.Count);

        Console.WriteLine($"The sum of all numbers in the list is {total}");
        Console.WriteLine($"The average of all numbers is {average}");
        Console.WriteLine($"The largest number in the list is {largest}");
        
    }
}