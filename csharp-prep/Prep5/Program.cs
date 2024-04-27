using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int fav_num = PromptUserNumber();

        int squared_num = SquareNumber(fav_num);

        DisplayResult(name, squared_num);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int fav_num = int.Parse(Console.ReadLine());
        
        return fav_num;
    }

    static int SquareNumber(int fav_num)
    {
        int squared_num = fav_num * fav_num;
        return squared_num;
    }

    static void DisplayResult(string name, int squared_num)
    {
        Console.WriteLine($"{name}, the square of your number is {squared_num}");
    }
}