namespace _19.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vacationCost = double.Parse(Console.ReadLine());
            var savings = double.Parse(Console.ReadLine());

            var spendingDays = 0;
            var days = 0;

            while (savings < vacationCost && spendingDays < 5)
            {
                string command = Console.ReadLine();
                var currentSum = double.Parse(Console.ReadLine());
                days++;

                if (command == "spend")
                {
                    savings -= currentSum;
                    spendingDays++;
                }
                else if (command == "save")
                {
                    savings += currentSum;
                    spendingDays = 0;
                }

                if (savings < 0)
                {
                    savings = 0;
                }
            }

            if (spendingDays >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}