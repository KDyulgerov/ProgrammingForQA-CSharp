namespace _08.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var totalReads = int.Parse(Console.ReadLine());

            var leftSum = 0;
            var rightSum = 0;

            for (int i = 1; i <= totalReads; i++)
            {
                var number = int.Parse(Console.ReadLine());
                leftSum += number;
            }
            for (int i = 1; i <= totalReads; i++)
            {
                var number = int.Parse(Console.ReadLine());
                rightSum += number;
            }

            var diff = Math.Abs(leftSum - rightSum);

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}