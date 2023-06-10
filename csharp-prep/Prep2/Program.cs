using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade percentage number (only) for this student?");
        string grade = Console.ReadLine();
        int grade_number = int.Parse(grade);

        string letter_final = "";
        bool pass = false;

        if (grade_number >= 90)
        {
            letter_final = "A";
            pass = true;
        }
        else if (grade_number >= 80)
        {
            letter_final = "B";
            pass = true;
        }
        else if (grade_number >= 70)
        {
            letter_final = "C";
            pass = true;
        }
        else if (grade_number >= 60)
        {
            letter_final = "D";
        }
        else 
        {
            letter_final = "F";
        }

        Console.WriteLine($"Your final grade is: {letter_final}");

        if (pass == true)
        {
            Console.WriteLine("Congratulation for passing this class!");
        }
        else
        {
            Console.WriteLine("You have not passed this class, you can try again and ask for support if needed.");
        }
    }
}