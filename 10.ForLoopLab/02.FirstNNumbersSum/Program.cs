namespace _02.FirstNNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var totalSum = 0;

            for (int i = 1; i <= number; i += 1)
            {
                if (i < number)
                {
                    Console.Write(i + "+");
                }
                else
                {
                    Console.Write(i + "=");
                }
                totalSum += i;
            }

            Console.WriteLine(totalSum);
        }
    }
}