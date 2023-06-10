using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your FIRST name?");
        string first_name = Console.ReadLine();
        Console.WriteLine("What is your LAST name?");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}