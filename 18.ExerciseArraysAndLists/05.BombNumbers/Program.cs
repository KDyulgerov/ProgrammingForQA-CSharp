List<int> numbers = Console.ReadLine() // 1 2 2 4 2 2 2 9
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> parameters = Console.ReadLine() // 4 2
    .Split()
    .Select(int.Parse)
    .ToList();

int bomb = parameters[0];
int bombPower = parameters[1];


for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bomb)
    {
        int startIndex = i - bombPower;
        int removeCount = bombPower + bombPower + 1;

        if (startIndex < 0)
        {
            removeCount -= Math.Abs(startIndex);
            startIndex = 0;
        }

        if (startIndex + removeCount > numbers.Count - 1)
        {
            removeCount = numbers.Count - startIndex;
        }
        numbers.RemoveRange(startIndex, removeCount);

        i = startIndex - 1;
    }
    
}

Console.WriteLine(numbers.Sum());