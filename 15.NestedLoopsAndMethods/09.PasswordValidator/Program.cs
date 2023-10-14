static bool LettersAndDigitsChecker(string password)
{
    for (int i = 0; i <= password.Length - 1; i++)
    {
        char currentLetter = password[i];
        if (char.IsLetterOrDigit(currentLetter) == false)
        {
            return false;
        }
    }
    return true;
}

static bool DigitsInString(string password)
{
    int count = 0;

    for (int i = 0; i <= password.Length - 1; i += 1)
    {
        char currentValue = password[i];

        if (char.IsDigit(currentValue))
        {
            count++;
        }
    }

    if (count < 2)
    {
        return false;
    }
    return true;
}

string password = Console.ReadLine();

bool isValid = true;

if (password.Length < 6 || password.Length > 10)
{
    Console.WriteLine($"Password must be between 6 and 10 characters");
    isValid = false;
}

if (LettersAndDigitsChecker(password) == false)
{
    Console.WriteLine("Password must consist only of letters and digits");
    isValid = false;
}
if (DigitsInString(password) == false)
{
    Console.WriteLine("Password must have at least 2 digits");
    isValid = false;
}


if (isValid)
{
    Console.WriteLine("Password is valid");
}