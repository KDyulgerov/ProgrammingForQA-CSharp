namespace _15.SpecialNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine()); // example: 521
            var startingNum = number;

            bool isSpecial = true;

            while (number > 0)
            {
                var lastDigit = number % 10; // = 1
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