namespace _05.SumOfNumbersV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int currentNum = 0;

            for (int i = 0; i < number; i += currentNum)
            {
                currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;

            }
            Console.WriteLine(sum);
        }
    }
}