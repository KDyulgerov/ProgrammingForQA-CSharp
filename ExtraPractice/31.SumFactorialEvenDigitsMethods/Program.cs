int number = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateFactorialEvenNum(number));

static int CalculateFactorialEvenNum(int number)
{
    string numberStr = number.ToString();

    int sum = 0;

    foreach(char c in numberStr)
    {
        int currentDigit = int.Parse(c.ToString());

        int factorial = currentDigit;

        if (currentDigit % 2 == 0)
        {
            for (int i = 1; i < currentDigit; i++)
            {
                factorial *= i;
            }
            sum += factorial;
        }
    }

    return sum;
}