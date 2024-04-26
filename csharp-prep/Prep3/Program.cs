using System;
using System.Data;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        string magic;
        string guess;
        int magic_num;
        int guess_num = 0;
        int count = 0;

        Console.Write("What is the magic number? ");
        magic = Console.ReadLine();
        magic_num = int.Parse(magic);

        while (guess_num != magic_num)
        {
            count += 1;
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guess_num = int.Parse(guess);

            if (guess_num > magic_num)
            {
                Console.WriteLine("Lower");
            }
            else if (guess_num < magic_num)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You guessed {count} times.");
            }
        }
    }
}