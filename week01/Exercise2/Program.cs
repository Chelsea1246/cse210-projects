using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
            Console.WriteLine("Your letter grade is A.");
        }
        else if (percent >= 80)
        {
            letter = "B";
            Console.WriteLine("Your letter grade is B.");
        }
        else if (percent >= 70)
        {
            letter = "C";
            Console.WriteLine("Your letter grade is C.");
        }
        else if (percent >= 60)
        {
            letter = "D";
            Console.WriteLine("Your letter grade is D.");
        }
        else
        {
            letter = "F";
            Console.WriteLine("Your letter grade is F.");
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better luck next time!");
        }
    }
}
