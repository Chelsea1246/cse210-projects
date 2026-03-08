using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);

        
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

        static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Player";
        }
        return name;
    }

    
    static int PromptUserNumber()
    {
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                return number;
            }
            Console.WriteLine("That doesn't look like a valid integer. Please try again.");
        }
    }

    
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Hello, {name}! Your number squared is {squaredNumber}.");
    }
}
