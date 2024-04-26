using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        float sum = 0;
        float average;
        int largest = 0;
        int isWorking = 1;
        int newNum;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (isWorking != 0)
        {
            Console.Write("Enter number: ");
            newNum = int.Parse(Console.ReadLine());
            numbers.Add(newNum);
            isWorking = newNum;
        }

        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
        }
        
        average = sum / (numbers.Count - 1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}