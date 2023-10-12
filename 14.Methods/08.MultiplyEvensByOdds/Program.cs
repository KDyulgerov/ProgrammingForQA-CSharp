
static int GetSumOfEvenDigits(int number)
{
    int sum = 0;

    for (int i = number; i > 0; i /= 10)
    {
        int currentDigit = i % 10;
        if (currentDigit % 2 == 0)
        {
            sum += currentDigit;
        }
    }
    return sum;
}

static int GetSumOfOddDigits(int number)
{
    int sum = 0;

    for (int i = number; i > 0; i /= 10)
    {
        int currentDigit = i % 10;
        if (currentDigit % 2 != 0)
        {
            sum += currentDigit;
        }
    }
    return sum;
}

static int GetMultipleOfEvenAndOdds(int number)
{
    int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);

    return result;
}


int number = int.Parse(Console.ReadLine());

number = Math.Abs(number);

int result = GetMultipleOfEvenAndOdds(number);

Console.WriteLine(result);

