int[] arrInput = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int range = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = arrInput.Length - 1; i > arrInput.Length - 1 - range; i--)
{
    sum += arrInput[i];
}

double average = sum * 1.0 / range;

Console.WriteLine($"{average:F2}");