using System;

class Program
{
    static int DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        int selection = int.Parse(Console.ReadLine());
        return selection;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        bool isRunning = true;
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Journal journal = new Journal();

        do
        {
            int selection = DisplayMenu();
            if (selection == 1)
            {
                PromptGenerator generator = new PromptGenerator();
                Entry newEntry = new Entry();
                
                newEntry._date = dateText;
                newEntry._promptText = generator.GetRandomPrompt();
                newEntry._entryText = Console.ReadLine();

                journal.AddEntry(newEntry);
            }

            else if (selection == 2)
            {
                journal.DisplayAll();
            }

            else if (selection == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (selection == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (selection == 5)
            {
                isRunning = false;
            }

            else
            {
                Console.WriteLine("That is not a valid option.");
            }
        } while (isRunning);
    }
}