namespace _13.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameActor = Console.ReadLine();
            var startingPoints = double.Parse(Console.ReadLine());
            var juryNum = int.Parse(Console.ReadLine());

            string nameJury = "";
            var juryPoints = 0.00;

            int i = 1;
            while (i <= juryNum && startingPoints <= 1250.5)
            {
                nameJury = Console.ReadLine();
                juryPoints = double.Parse(Console.ReadLine());

                startingPoints += (juryPoints * nameJury.Length / 2);

                i++;
            }

            var diff = (1250.5 - startingPoints);

            if (startingPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameActor} got a nominee for leading role with {startingPoints:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameActor} you need {diff:F1} more!");
            }
        }
    }
}