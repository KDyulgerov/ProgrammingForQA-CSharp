namespace _03.BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countNumbers = int.Parse(Console.ReadLine());

            var maxNumber = int.MinValue;

            for (int i = 1; i <= countNumbers; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                if (currentNum > maxNumber)
                {
                    maxNumber = currentNum;
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}