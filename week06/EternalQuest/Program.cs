using System;

class Program
{
    static void Main(string[] args)
    {

GoalManager manager = new GoalManager();

while (true)
{
    Console.WriteLine("1. Create Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Record Event");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Load");
    Console.WriteLine("6. Quit");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        // create goal logic
    }
    else if (choice == "2")
    {
        manager.DisplayGoals();
    }
    else if (choice == "3")
    {
        manager.DisplayGoals();
        int index = int.Parse(Console.ReadLine()) - 1;
        manager.RecordEvent(index);
    }
}
    }
}