namespace _07.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());

            var maxNum = int.MinValue;
            var minNum = int.MaxValue;

            for (int i = 1; i <= numbers; i += 1)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber;
                }

                if (currentNumber < minNum)
                {
                    minNum = currentNumber;
                }
            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}