namespace _06.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            bool isSpecial = true;
            var startingNum = number;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (startingNum % lastDigit != 0)
                {
                    isSpecial = false;
                    break;
                }

                number /= 10;
            }

            if (isSpecial)
            {
                Console.WriteLine($"{startingNum} is special");
            }
            else
            {
                Console.WriteLine($"{startingNum} is not special");
            }
        }
    }
}