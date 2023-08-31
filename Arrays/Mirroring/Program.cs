int[,] tableOfNumbers = new int[,]
{
    {1, 2, 3, 4 },
    {5, 6, 7, 8 }
};

for (int i = 0; i < tableOfNumbers.Length; i++)
{
    for (int j = 0; j < tableOfNumbers.GetLength(i); j++)
    {
        Console.WriteLine(tableOfNumbers[i , j] + " ");
    }
}
Console.WriteLine();