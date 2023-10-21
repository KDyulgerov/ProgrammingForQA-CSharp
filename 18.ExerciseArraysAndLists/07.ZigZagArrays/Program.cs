List<int> firstCollection = new List<int>();

List<int> secondCollection = new List<int>();

int spins = int.Parse(Console.ReadLine());

for (int i = 1; i <= spins; i += 1)
{
    List<int> currentNumbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

    int firstNum = currentNumbers[0];
    int secondNum = currentNumbers[1];

    if (i % 2 != 0)
    {
        firstCollection.Add(firstNum);
        secondCollection.Add(secondNum);
    }
    else if (i % 2 == 0)
    {
        firstCollection.Add(secondNum);
        secondCollection.Add(firstNum);
    }
}

Console.WriteLine(string.Join(" ", firstCollection));
Console.WriteLine(string.Join(" ", secondCollection));