
List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

int rotationCounter = int.Parse(Console.ReadLine());

for (int i = 1; i <= rotationCounter; i += 1)
{
    numbers.Add(numbers[0]);
    numbers.RemoveAt(0);
}

Console.WriteLine(string.Join(" ", numbers));