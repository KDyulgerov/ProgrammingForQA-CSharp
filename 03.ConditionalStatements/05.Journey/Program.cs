namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string typeVacation = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    budget *= 0.30;
                    typeVacation = "Camp";
                }
                else if (season == "winter")
                {
                    typeVacation = "Hotel";
                    budget *= 0.70;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    budget *= 0.40;
                    typeVacation = "Camp";
                }
                else if (season == "winter")
                    typeVacation = "Hotel";
                budget *= 0.80;
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                typeVacation = "Hotel";
                budget *= 0.90;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeVacation} - {budget:F2}");
        }
    }
}