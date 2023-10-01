namespace _02.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            var countFlowers = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());

            var pricePerFlower = 0.00;

            switch (typeFlowers)
            {
                case "Roses":
                {
                    pricePerFlower = 5.00;
                    if (countFlowers > 80)
                        pricePerFlower *= 0.90;
                    break;
                }
                case "Dahlias":
                {
                    pricePerFlower = 3.80;
                    if (countFlowers > 90)
                        pricePerFlower *= 0.85;
                    break;
                }
                case "Tulips":
                {
                    pricePerFlower = 2.80;
                    if (countFlowers > 80)
                        pricePerFlower *= 0.85;
                    break;
                }
                case "Narcissus":
                {
                    pricePerFlower = 3.00;
                    if (countFlowers < 120)
                        pricePerFlower *= 1.15;
                    break;
                }
                case "Gladiolus":
                {
                    pricePerFlower = 2.50;
                    if (countFlowers < 80)
                        pricePerFlower *= 1.20;
                    break;
                }
            }
            var totalPrice = countFlowers * pricePerFlower;
            var diff = Math.Abs(totalPrice - budget);
            if (totalPrice <= budget)
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlowers} and {diff:F2} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {diff:F2} leva more.");
        }
    }
}