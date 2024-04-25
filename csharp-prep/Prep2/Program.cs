using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter;
        int grade;
        bool isPassing = true;
        float remainder;
        string sign;


        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        grade = int.Parse(userInput);

        if (grade >= 90)
        {
            gradeLetter = "A";
            isPassing = false;
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
            isPassing = true;
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
            isPassing = true;
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
            isPassing = true;
        }
        else
        {
            gradeLetter = "F";
            isPassing = false;
        }

        remainder = grade % 10;

        if (remainder >= 0.7 && gradeLetter != "A" && gradeLetter != "F")
        {
            sign = "+";
        }
        else if (remainder < 0.3 && gradeLetter != "F")
        {
            sign ="-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade: {grade}  Grade Letter: {gradeLetter}{sign}");

        if (isPassing == true)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("You can do better!");
        }
    }
}