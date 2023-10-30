int number = int.Parse(Console.ReadLine()); //4532

int sum = 0;
while (number > 0)
{
    int lastDigit = number % 10;

    if (lastDigit % 2 == 0 )
    {
        int currentSum = lastDigit;

        for (int i = 1; i < lastDigit; i += 1)
        {
            currentSum *= i;
        }
        sum += currentSum;
    }
    number /= 10;
}

Console.WriteLine(sum);