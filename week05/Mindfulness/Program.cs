using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {

while (true)
{
    Console.WriteLine("Hello World! This is the Mindfulness Project.");
    Console.WriteLine("1. Breathing Activity");
    Console.WriteLine("2. Reflection Activity");
    Console.WriteLine("3. Listing Activity");
    Console.WriteLine("4. Quit");
    Console.Write("Please select an activity (1-4): ");

    string choice = Console.ReadLine();
    if (choice == "1")
    {
        BreathingActivity activity = new BreathingActivity();
        activity.Run();
    }
    else if (choice == "2")
    {
        ReflectionActivity reflection = new ReflectionActivity();
        reflection.Run();
    }
    else if (choice == "3")
    {
        ListingActivity listing = new ListingActivity();
        listing.Run();
    }
    else if (choice == "4")
    {
        break;
    }
  }
 }
}


