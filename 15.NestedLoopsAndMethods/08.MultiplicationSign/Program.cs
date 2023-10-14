static void MultiplicationSign(int num1, int num2, int num3)
{
    string sign = "";

    if (num1 > 0 && num2 > 0 && num3 > 0
        || num1 > 0 && num2 < 0 && num3 < 0
        || num1 < 0 && num2 < 0 && num3 > 0
        || num1 < 0 && num2 > 0 && num3 < 0)
    {
        sign = "positive";
    }
    else if (num1 < 0 && num2 < 0 && num3 < 0
             || num1 > 0 && num2 > 0 && num3 < 0
             || num1 > 0 && num2 < 0 && num3 > 0
             || num1 < 0 && num2 > 0 && num3 > 0)
    {
        sign = "negative";
    }
    else if (num1 == 0 || num2 == 0 || num3 == 0)
    {
        sign = "zero";
    }

    Console.WriteLine(sign);
}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

MultiplicationSign(num1, num2, num3);
