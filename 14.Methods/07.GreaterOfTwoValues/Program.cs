
static int GreaterOfInt(int number1, int number2)
{
    if (number1 > number2)
    {
        return number1;
    }
    else
    {
        return number2;
    }
}

static char GreaterOfChar(char chr1, char chr2)
{
    if (chr1 > chr2)
    {
        return chr1;
    }
    else
    {
        return chr2;
    }
}

static string GreaterOfString(string str1, string str2)
{
    if (str1.CompareTo(str2) > 0)
    {
        return str1;
    }
    else
    {
        return str2;
    }
}


string type = Console.ReadLine();

if (type == "int")
{
    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());

    int result = GreaterOfInt(number1, number2);

    Console.WriteLine(result);
}
else if (type == "char")
{
    char chr1 = char.Parse(Console.ReadLine());
    char chr2 = char.Parse(Console.ReadLine());

    char result = GreaterOfChar(chr1, chr2);
    Console.WriteLine(result);
}
else if (type == "string")
{
    string str1 = Console.ReadLine();
    string str2 = Console.ReadLine();

    string result = GreaterOfString(str1, str2);
    Console.WriteLine(result);
}

