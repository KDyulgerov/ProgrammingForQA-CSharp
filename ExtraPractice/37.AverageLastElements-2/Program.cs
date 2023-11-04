List<int> listInput = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int range = int.Parse(Console.ReadLine());

listInput.Reverse();

List<int> lastDigits = listInput.Take(range).ToList();

double average = lastDigits.Average();

Console.WriteLine($"{average:F2}");

