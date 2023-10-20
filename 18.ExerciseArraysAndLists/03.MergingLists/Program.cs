List<int> inputOne = Console.ReadLine() // 2, 3, 5, 7, 13
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> inputTwo = Console.ReadLine() // 1, 3, 4, 12
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> output = new List<int>();

int biggerInput = Math.Max(inputOne.Count, inputTwo.Count);

for (int i = 0; i < biggerInput; i++)
{
    if (i < inputOne.Count)
    {
        output.Add(inputOne[i]);
    }

    if (i < inputTwo.Count)
    {
        output.Add(inputTwo[i]);
    }
   
}

Console.WriteLine(string.Join(" ", output));