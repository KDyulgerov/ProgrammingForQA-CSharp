int[] numbers = Console.ReadLine() // 3 4 6 7 8 9
    .Split()
    .Select(int.Parse)
    .ToArray();

int middleNum = numbers.Length / 2;

double sum = numbers[middleNum - 1] + numbers[middleNum];

double average = sum / 2;

Console.WriteLine($"{average:F2}");