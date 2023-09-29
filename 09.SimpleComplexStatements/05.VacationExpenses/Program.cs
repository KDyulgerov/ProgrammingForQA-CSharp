namespace _05.VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine(); // 4 seasons
            string type = Console.ReadLine(); // hotel or camping
            var days = int.Parse(Console.ReadLine());

            var pricePerDay = 0.00;
            var discount = 1.00;

            switch (season)
            {
                case "Spring":
                {
                    if (type == "Hotel")
                        pricePerDay = 30;
                    else if (type == "Camping")
                    {
                        pricePerDay = 10;
                    }
                    discount = 0.80;
                    break;
                }
                case "Summer":
                {
                    if (type == "Hotel")
                        pricePerDay = 50;
                    else if (type == "Camping")
                    {
                        pricePerDay = 30;
                    }
                    break;
                }
                case "Autumn":
                {
                    if (type == "Hotel")
                        pricePerDay = 20;
                    else if (type == "Camping")
                    {
                        pricePerDay = 15;
                    }
                    discount = 0.70; 
                    break;
                }
                case "Winter":
                {
                    if (type == "Hotel")
                        pricePerDay = 40;
                    else if (type == "Camping")
                    {
                        pricePerDay = 10;
                    }
                    discount = 0.90; 
                    break;
                }
            }
            var finalPrice = (pricePerDay * days) * discount;
            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}