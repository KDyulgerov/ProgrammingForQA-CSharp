
int num = int.Parse(Console.ReadLine());

List<int> primeNumbers = new List<int>();

for (int i = 1; i <= num; i += 1)
{
    if (IsDivideByTwo(i) == true && IsAllDiitsPrime(i) == true)
    {
        primeNumbers.Add(i);
    }
}
Console.WriteLine(string.Join(" ", primeNumbers));
if (primeNumbers.Count < 1)
{
    Console.WriteLine("no");
}

static bool IsAllDiitsPrime(int num)
{
    string currentDigit = num.ToString();
    bool isAllPrime = true;

    foreach (char c in currentDigit)
    {
        int digit = int.Parse(c.ToString());

        if(IsPrimeNumber(digit) == false)
        {
            isAllPrime = false;
            break;
        }
    }
    if (isAllPrime)
    {
        return true;
    }
    else
    {
        return false;
    }
        
}
static bool IsDivideByTwo(int i)
{
    string numberString = i.ToString();
    int sumNum = 0;

    foreach (int c in numberString)
    {
        int currentDigit = int.Parse(c.ToString());
        sumNum += currentDigit;
    }
    if (sumNum % 2 != 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}
static bool IsPrimeNumber(int num)
{
    int divisors = 0;

    for (int i = 1; i <= num; i += 1)
    {
        if (num % i == 0)
        {
            divisors += 1;
        }

        if (divisors > 2)
        {
            divisors = 0;
            break;
        }
    }
    if (divisors == 2)
    {
        return true;
    }
    return false;
}
