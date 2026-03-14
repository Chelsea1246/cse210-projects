using System;

class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();
       PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to a file");
            Console.WriteLine("4. Load entries from a file");
            Console.WriteLine("5. Exit");

            Console.Write("What was the best part of your day? ");

            Console.Write("Choose an option: ");
            
            

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("Your entry: ");
                string entryText = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                newEntry._promptText = prompt;
                newEntry._responseText = entryText;

                journal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
    }
 }
}
