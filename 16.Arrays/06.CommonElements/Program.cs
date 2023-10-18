int[] firstNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int i = 0; i <= firstNumbers.Length - 1; i += 1)
{
    for (int j = 0; j <= secondNumbers.Length - 1; j += 1)
    {
        if (firstNumbers[i] == secondNumbers[j])
        {
            Console.Write(firstNumbers[i] + " ");
        }
    }
}