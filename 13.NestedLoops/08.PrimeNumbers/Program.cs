namespace _08.PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine()); // 5 
            var end = int.Parse(Console.ReadLine()); // 50

            for (int currentDigit = start; currentDigit < end; currentDigit += 1)
            {
                var divisors = 0;

                for (int j = 1; j <= currentDigit; j += 1)
                {
                    if (currentDigit % j == 0)
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
                    Console.Write($"{currentDigit} ");
                }

            }
        }
    }
}