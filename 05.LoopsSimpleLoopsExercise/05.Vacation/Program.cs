using System.ComponentModel.DataAnnotations;

namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneyAvailable = double.Parse(Console.ReadLine());

            int spendingDays = 0;
            int totalDays = 0;
            

            while (moneyAvailable < moneyNeeded && spendingDays < 5)
            {
                string type = Console.ReadLine(); // "spend" or "save"
                double amount = double.Parse(Console.ReadLine());

                if (type == "spend")
                {
                    moneyAvailable -= amount;
                    spendingDays += 1;
                    if (moneyAvailable < 0)
                    {
                        moneyAvailable = 0;
                    }
                }
                else if (type == "save")
                {
                    moneyAvailable += amount;
                    spendingDays = 0;
                }

                totalDays += 1;
            }
            if (spendingDays >= 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{totalDays}");
            }
            else if (moneyAvailable >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
        }
    }
}