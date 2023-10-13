
char startLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());
char excludedLetter = char.Parse(Console.ReadLine());

int count = 0;

for (char firstChar = startLetter; firstChar <= endLetter; firstChar++)
{
    for (char secondChar = startLetter; secondChar <= endLetter; secondChar++)
    {
        for (char thirdChar = startLetter; thirdChar <= endLetter; thirdChar++)
        {
            if (firstChar != excludedLetter && secondChar != excludedLetter && thirdChar != excludedLetter)
            {
                Console.Write($"{firstChar}{secondChar}{thirdChar} ");
                count++;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine(count);