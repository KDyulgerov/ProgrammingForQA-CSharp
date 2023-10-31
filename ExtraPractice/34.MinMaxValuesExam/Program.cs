int[] arrayInput = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int range = int.Parse(Console.ReadLine());

int minValue = int.MaxValue;
int maxValue = int.MinValue;

for (int i = 0; i < range; i++)
{
    if (arrayInput[i] > maxValue)
    {
        maxValue = arrayInput[i];
    }
    if (arrayInput[i] < minValue)
    {
        minValue = arrayInput[i];
    }
}

Console.WriteLine(maxValue);
Console.WriteLine(minValue);