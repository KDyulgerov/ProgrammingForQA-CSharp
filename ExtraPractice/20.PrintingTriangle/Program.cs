static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i += 1)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}

static void PrintTriangle(int number)
{
    for (int currentLine = 1; currentLine <= number; currentLine += 1)
    {
        PrintLine(1, currentLine);
    }

    for (int currentLine = number - 1; currentLine >= 1; currentLine -= 1)
    {
        PrintLine(1, currentLine);
    }
}
int number = int.Parse(Console.ReadLine());

PrintTriangle(number);

