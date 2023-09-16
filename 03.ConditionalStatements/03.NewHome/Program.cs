namespace _03.NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String flower = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cost = 0;

            switch(flower)
            {
                case "Roses":
                    cost = flowersCount * 5.00;
                    if (flowersCount > 80)
                        cost = cost * 0.9;
                    break;

                case "Dahlias":
                    cost = flowersCount * 3.80;
                    if (flowersCount > 90)
                        cost = cost * 0.85;
                    break;

                case "Tulips":
                    cost = flowersCount * 2.8;
                    if (flowersCount > 80)
                        cost = cost * 0.85;
                    break;

                case "Narcissus":
                    cost = flowersCount * 3;
                    if (flowersCount < 120)
                        cost = cost * 1.15;
                    break;

                case "Gladiolus":
                    cost = flowersCount * 2.5;
                    if (flowersCount < 80)
                        cost = cost * 1.2;
                    break;
            }

            if (budget >= cost)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flower} and {(budget - cost):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(cost - budget):F2} leva more.");
            }
        }
    }
}