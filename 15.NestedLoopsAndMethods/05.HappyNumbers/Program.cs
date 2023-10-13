
int number = int.Parse(Console.ReadLine()); 

// 1000 - 9999

for (int firstDig = 1; firstDig <= 9; firstDig++)
{
    for (int secondDig = 0; secondDig <= 9; secondDig++)
    {
        for (int thirdDig = 0; thirdDig <= 9; thirdDig++)
        {
            for (int fourthDig = 0; fourthDig <= 9; fourthDig++)
            {
                if (firstDig + secondDig == number && thirdDig + fourthDig == number)
                {
                    Console.Write($"{firstDig}{secondDig}{thirdDig}{fourthDig} ");
                }
            }
        }
    }
}