static void SignOfNumber(int number)
{
    if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else if (number == 0)
    {
        Console.WriteLine($"The number {number} is zero.");
    }
    else
    {
        Console.WriteLine($"The number {number} is negative.");
    }
}

var number = int.Parse(Console.ReadLine());
SignOfNumber(number);