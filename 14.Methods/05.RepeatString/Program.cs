static void PrintMultipleText(string text, int repeat)
{
    for (int i = 1; i <= repeat; i++)
    {
        Console.Write(text);
    }
}

string text = Console.ReadLine();
int repeat = int.Parse(Console.ReadLine());

PrintMultipleText(text, repeat);