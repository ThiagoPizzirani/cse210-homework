using System;
class Program
{  
     static void Welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string Name()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int Number()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int Square(int number)
    {
        int square = number * number;
        return square;
    }

    static void Print(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
     static void Main(string[] args)
    {
        Welcome();

        string inputName = Name();
        int inputNumber = Number();

        int square = Square(inputNumber);

        Print(inputName, square);
    }
}