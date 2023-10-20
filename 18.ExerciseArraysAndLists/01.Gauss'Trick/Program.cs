List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
    
List<int> calculatedNums = new List<int>();

for (int i = 0; i < numbers.Count / 2; i += 1)
{
    int calculatedNum = numbers[i] + numbers[numbers.Count - 1 - i];
    calculatedNums.Add(calculatedNum);
}

if (numbers.Count % 2 != 0)
{
    calculatedNums.Add(numbers[numbers.Count / 2]);
}

Console.WriteLine(string.Join(" ", calculatedNums));