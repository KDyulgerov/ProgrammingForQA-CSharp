using System.Threading.Channels;

static void PrintLine(int end)
{
    for (int i = 1; i <= end; i += 1)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}

static void PrintTiangle(int num)
{
    for (int currentLine = 1; currentLine <= num; currentLine += 1)
    {
        PrintLine(currentLine);
    }

    for (int currentLine = num - 1; currentLine >= 1; currentLine -= 1)
    {
        PrintLine(currentLine);
    }

}
var end = int.Parse(Console.ReadLine());
PrintTiangle(end);

