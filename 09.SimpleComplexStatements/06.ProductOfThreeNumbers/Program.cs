namespace _06.ProductOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());

            int negativeCount = 0;

            if (num1 < 0)
            {
                negativeCount++;
            }
            if (num2 < 0)
            {
                negativeCount++;
            }
            if (num3 < 0)
            {
                negativeCount++;
            }

            string result = "";

            if (negativeCount % 2 == 0)
            {
                result = "positive";
            }
            else
            {
                result = "negative";
            }

            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                result = "zero";
            }

            Console.WriteLine($"{result}");
        }
    }
}