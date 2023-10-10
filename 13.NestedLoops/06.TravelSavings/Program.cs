using System.Diagnostics.CodeAnalysis;

namespace _06.TravelSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                var tripBudget = double.Parse(Console.ReadLine());

                var savedMoney = 0.0;

                while (savedMoney < tripBudget)
                {
                    var sum = double.Parse(Console.ReadLine());
                    savedMoney += sum;
                    Console.WriteLine($"Collected: {savedMoney:F2}");
                }
                Console.WriteLine($"Going to {destination}!");

            }
        }
    }
}