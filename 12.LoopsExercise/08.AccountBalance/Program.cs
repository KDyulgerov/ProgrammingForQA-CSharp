namespace _08.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var totalAmount = 0.0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }
                var amount = double.Parse(command);

                if (amount > 0)
                {
                    totalAmount += amount;
                    Console.WriteLine($"Increase: {amount:F2}");
                }
                else if (amount < 0)
                {
                    totalAmount += amount;
                    Console.WriteLine($"Decrease: {Math.Abs(amount):F2}");
                }
            }

            Console.WriteLine($"Balance: {totalAmount:F2}");
        }
    }
}