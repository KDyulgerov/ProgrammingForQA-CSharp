namespace _16.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var compNumber = int.Parse(Console.ReadLine());
            var startingPoints = int.Parse(Console.ReadLine());
            var tournamentPoints = 0;
            var wins = 0;

            for (int i = 1; i <= compNumber; i++)
            {
                string status = Console.ReadLine();

                switch (status)
                {
                    case "W":
                    {
                        tournamentPoints += 2000;
                        wins++;
                        break;
                    }
                    case "F":
                    {
                        tournamentPoints += 1200;
                        break;
                    }
                    case "SF":
                    {
                        tournamentPoints += 720;
                        break;
                    }
                }
            }

            Console.WriteLine($"Final points: {startingPoints + tournamentPoints}");
            Console.WriteLine($"Average points: {tournamentPoints / compNumber}");
            Console.WriteLine($"{wins * 1.0 / compNumber * 100:F2}%");
        }
    }
}