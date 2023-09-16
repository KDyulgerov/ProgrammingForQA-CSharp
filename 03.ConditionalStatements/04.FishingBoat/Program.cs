namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double priceRent = 0;

            switch(season)
            {
                case "Spring":
                    priceRent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    priceRent = 4200;
                    break;
                case "Winter":
                    priceRent = 2600;
                    break;
            }
            if (fishermanCount <= 6)
                priceRent *= 0.90;
            else if (fishermanCount > 6 && fishermanCount <= 11)
                priceRent *= 0.85;
            else if (fishermanCount >= 12)
                priceRent *= 0.75;

            if (fishermanCount % 2 == 0 && season != "Autumn")
                priceRent *= 0.95;

            if (groupBudget >= priceRent)
            {
                Console.WriteLine($"Yes! You have {groupBudget - priceRent:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {priceRent - groupBudget:F2} leva.");
            }
        }
    }
}