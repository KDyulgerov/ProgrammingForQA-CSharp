namespace _07.SumOfDigitsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }

                var num = int.Parse(command);
                var sum = 0;

                for (int i = num; i > 0; i /= 10)
                {
                    var lastDigit = i % 10;
                    sum += lastDigit;
                }

                Console.WriteLine($"Sum of digits = {sum}");

            }
        }
    }
}