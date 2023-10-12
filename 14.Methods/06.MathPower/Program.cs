static int MathPowerMethod(int number, int power)
{
    int sum = number;
    for (int i = 1; i < power; i++) 
    {
        sum *= number;
    }
    return sum;
}

int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int result = MathPowerMethod(number, power);

Console.WriteLine(result);