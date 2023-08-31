using System;

class Search
{
    static void Main()
    {
        int[] numbers = { 10, 25, 7, 42, 15, 30, 5, 18, 50 };

        Console.Write("Enter a number to search for: ");
        int target = int.Parse(Console.ReadLine());

        int position = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                position = i;
                break;
            }
        }

        if (position != -1)
        {
            Console.WriteLine($"Number {target} found in position {position} in array.");
        }
        else
        {
            Console.WriteLine($"Number {target} is missing from the array.");
        }
    }
}