namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var totalSum = 0.0;

            for (int i = 1; i <= number; i += 1)
            {
                var sum = double.Parse(Console.ReadLine());
                totalSum += sum;
            }
            Console.WriteLine(totalSum);
        }
    }
}