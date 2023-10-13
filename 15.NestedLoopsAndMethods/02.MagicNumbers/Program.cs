
int number = int.Parse(Console.ReadLine());

// 100 999

for (int firstNum = 1; firstNum <= 9; firstNum++)
{
    for (int secondNum = 0; secondNum <= 9; secondNum++)
    {
        for (int thirdNum = 0; thirdNum <= 9; thirdNum++)
        {
            if (firstNum * secondNum * thirdNum == number)
            {
                Console.Write($"{firstNum}{secondNum}{thirdNum} ");
            }
        }
    }
}