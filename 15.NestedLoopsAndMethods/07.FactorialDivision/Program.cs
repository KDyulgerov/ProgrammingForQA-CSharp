
static double CalculateFactorial(int number)
{
    double factorial = 1.0;

    for (int i = number; i >= 1; i--)
    {
        factorial *= i;
    }
    return factorial;
}

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

double result1 = CalculateFactorial(number1);
double result2 = CalculateFactorial(number2);

Console.WriteLine(result1 / result2);

