static void VowelsCount(string text)
{
    int countVowels = 0;

    for (int i = 0; i <= text.Length - 1; i++)
    {
        char currentChar = text[i];

        if (currentChar == 'A' || currentChar == 'a' 
            || currentChar == 'O' || currentChar == 'o'
            || currentChar == 'U' || currentChar == 'u'
            || currentChar == 'E' || currentChar == 'e'
            || currentChar == 'I' || currentChar == 'i')
        {
            countVowels++;
        }
    }

    Console.WriteLine(countVowels);
}

string text = Console.ReadLine();

VowelsCount(text);

