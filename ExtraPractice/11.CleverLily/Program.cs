namespace _11.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var yearsOld = int.Parse(Console.ReadLine());
            var laundryPrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var birthdayCash = 10;
            var toysCounter = 0;

            for (int i = 1; i <= yearsOld; i += 1)
            {
                if (i % 2 == 0)
                {
                    sum += birthdayCash - 1;
                    birthdayCash += 10;
                }
                else
                {
                    toysCounter++;
                }
            }

            var totalSum = sum + (toysCounter * toyPrice);
            var diff = Math.Abs(totalSum - laundryPrice);

            if (totalSum >= laundryPrice)
            {
                Console.WriteLine($"Yes! {diff:F2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:F2}");
            }
        }
    }
}