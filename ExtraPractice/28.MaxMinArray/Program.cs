int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int minNum = int.MaxValue;
int maxNum = int.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < minNum)
    {
        minNum = numbers[i];
    }

    if (numbers[i] > maxNum)
    {
        maxNum = numbers[i];
    }
}

Console.WriteLine($"Max number is: {maxNum}");
Console.WriteLine($"Min number is: {minNum}");