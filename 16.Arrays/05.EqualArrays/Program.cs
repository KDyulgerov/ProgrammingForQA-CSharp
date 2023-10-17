int[] firstNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isIdentical = true;

for (int i = 0; i <= firstNumbers.Length - 1; i += 1)
{
    if (firstNumbers[i] != secondNumbers[i])
    {
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}