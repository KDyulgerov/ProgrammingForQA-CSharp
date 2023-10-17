
int num = int.Parse(Console.ReadLine());

int[] numbers = new int[num];

for (int i = 0; i <= num - 1; i += 1)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int j = num - 1; j >= 0; j -= 1)
{
    Console.Write(numbers[j] + " ");
}