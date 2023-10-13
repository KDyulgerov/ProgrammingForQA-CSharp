
int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for (int firstNum = 2; firstNum <= max1; firstNum += 2)
{
    for (int secondNum = 1; secondNum <= max2; secondNum++) // 2, 3, 5, 7
    {
        for (int thirdNum = 2; thirdNum <= max3; thirdNum += 2)
        {
            if (secondNum == 2
                || secondNum == 3
                || secondNum == 5
                || secondNum == 7)
            {
                Console.WriteLine($"{firstNum}{secondNum}{thirdNum}");
            }
        }
    }
}
