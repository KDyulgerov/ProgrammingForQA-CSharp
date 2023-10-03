namespace _09.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numReads = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int totalSum = 0;

            for (int i = 1; i <= numReads; i += 1)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                totalSum += currentNumber;

                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber;
                }
            }

            var remainingSum = totalSum - maxNum;
            var diff = Math.Abs(remainingSum - maxNum);
            if (remainingSum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {remainingSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}