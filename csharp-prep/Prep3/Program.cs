using System;

class Program
{
    static void Main(string[] args)
    {
    Random randomGenerator = new Random();
    int number = randomGenerator.Next(1, 101);
    Console.WriteLine($"Original random is {number}");

        Console.WriteLine("What is the magic number?");
        string guess = Console.ReadLine();
        int guess_number = int.Parse(guess);

        while (number != guess_number)
        {
            if (number > guess_number)
            {
                Console.WriteLine("Guess needs to be higher"); 
            }
            else
            {
                Console.WriteLine("Guess needs to be lower"); 
            }

            Console.WriteLine("What is the magic number?");
            guess = Console.ReadLine();
            guess_number = int.Parse(guess);
        }
        Console.WriteLine("Congratulations, you guessed it right!");

        Random autoRandom = new Random();
        int numberSecond = randomGenerator.Next(1, 101);
        Console.WriteLine($"Program generated random input is {numberSecond}");

        while (number != numberSecond)
        {
            if (number > numberSecond)
            {
                Console.WriteLine($"Generated input is {numberSecond} - guess needs to be higher"); 
            }
            else
            {
                Console.WriteLine($"Generated input is {numberSecond} - guess needs to be lower"); 
            }
            
            numberSecond = randomGenerator.Next(1, 101);
        }
        Console.WriteLine($"Congratulations the number was {number}, your program guessed it right!");
    }
}