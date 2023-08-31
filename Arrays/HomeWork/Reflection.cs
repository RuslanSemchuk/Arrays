using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 7, 42, 15, 30, 5, 18, 50 };

        Console.WriteLine("Initial array of numbers:");
        PrintArray(numbers);

        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }

        Console.WriteLine("\nArray of numbers after \\\"mirroring\":");
        PrintArray(numbers);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
} 